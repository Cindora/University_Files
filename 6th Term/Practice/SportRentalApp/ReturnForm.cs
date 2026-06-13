using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace SportRentalApp
{
    public partial class ReturnForm : Form
    {
        private bool isLoading = false; // защита от рекурсии

        public ReturnForm()
        {
            InitializeComponent();
            LoadOpenContracts();
            // Подписка на события (если не сделано в дизайнере)
            cmbContract.SelectedIndexChanged += CmbContract_SelectedIndexChanged;
            btnCalculate.Click += BtnCalculate_Click;
            btnReturn.Click += BtnReturn_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        // 1. Загрузка открытых договоров в ComboBox
        private void LoadOpenContracts()
        {
            string query = @"
                SELECT 
                    rc.id, 
                    rc.id || ' - ' || c.last_name || ' ' || c.first_name || ' ' || COALESCE(c.middle_name, '') || ' (выдан: ' || TO_CHAR(rc.issue_timestamp, 'DD.MM.YYYY HH24:MI') || ')' AS DisplayText,
                    rc.issue_timestamp,
                    rc.planned_return_timestamp
                FROM RentalContract rc
                JOIN Client c ON rc.client_id = c.id
                WHERE rc.status = 'open'";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            cmbContract.DataSource = dt;
            cmbContract.DisplayMember = "DisplayText";
            cmbContract.ValueMember = "id";
        }

        // 2. При выборе договора загружаем его позиции
        private void CmbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (cmbContract.SelectedValue == null) return;
            
            if (!int.TryParse(cmbContract.SelectedValue.ToString(), out int contractId))
            {
                return;
            }

            isLoading = true;
            try
            {
                LoadContractItems(contractId);
            }
            finally
            {
                isLoading = false;
            }
        }

        // 3. Загрузка позиций договора (инвентаря)

        private void LoadContractItems(int contractId)
        {
            string query = @"
        SELECT 
            ci.id, 
            ci.inventory_id, 
            i.name, 
            i.characteristics, 
            i.price_per_hour, 
            ci.damaged, 
            ci.condition_on_return
        FROM ContractItem ci
        JOIN Inventory i ON ci.inventory_id = i.id
        WHERE ci.contract_id = @cid";

            var param = new NpgsqlParameter("cid", contractId);
            DataTable dt = DatabaseHelper.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("По данному договору нет позиций инвентаря.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvContractItems.DataSource = null;
                return;
            }

            // Разрешаем редактирование полей в DataTable (это ключевой момент!)
            if (dt.Columns.Contains("damaged"))
                dt.Columns["damaged"].ReadOnly = false;
            if (dt.Columns.Contains("condition_on_return"))
                dt.Columns["condition_on_return"].ReadOnly = false;

            // Привязываем DataTable к DataGridView
            dgvContractItems.AutoGenerateColumns = true;
            dgvContractItems.DataSource = dt;

            // Настройка внешнего вида (теперь ReadOnly у колонок грида менять не нужно)
            if (dgvContractItems.Columns["id"] != null)
                dgvContractItems.Columns["id"].Visible = false;
            if (dgvContractItems.Columns["inventory_id"] != null)
                dgvContractItems.Columns["inventory_id"].Visible = false;

            if (dgvContractItems.Columns["name"] != null)
                dgvContractItems.Columns["name"].HeaderText = "Инвентарь";
            if (dgvContractItems.Columns["characteristics"] != null)
                dgvContractItems.Columns["characteristics"].HeaderText = "Характеристики";
            if (dgvContractItems.Columns["price_per_hour"] != null)
                dgvContractItems.Columns["price_per_hour"].HeaderText = "Цена/час";
            if (dgvContractItems.Columns["damaged"] != null)
                dgvContractItems.Columns["damaged"].HeaderText = "Повреждён";
            if (dgvContractItems.Columns["condition_on_return"] != null)
                dgvContractItems.Columns["condition_on_return"].HeaderText = "Состояние при возврате";

            // Убедимся, что колонка damaged — чекбокс (если вдруг нет)
            if (dgvContractItems.Columns["damaged"] != null && !(dgvContractItems.Columns["damaged"] is DataGridViewCheckBoxColumn))
            {
                var checkCol = new DataGridViewCheckBoxColumn();
                checkCol.Name = "damaged";
                checkCol.HeaderText = "Повреждён";
                checkCol.DataPropertyName = "damaged";
                // ReadOnly не трогаем — оно наследуется от DataTable (у нас false)
                int idx = dgvContractItems.Columns["damaged"].Index;
                dgvContractItems.Columns.Remove("damaged");
                dgvContractItems.Columns.Insert(idx, checkCol);
            }

            dgvContractItems.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvContractItems.Refresh();
            CalculateTotalCost();
        }

        // 4. Расчёт общей стоимости (вызывается по кнопке или при изменении данных)
        private void CalculateTotalCost()
        {
            if (cmbContract.SelectedValue == null) return;
            if (!int.TryParse(cmbContract.SelectedValue.ToString(), out int contractId)) return;
            if (dgvContractItems.Rows.Count == 0) return;

            // Получаем дату выдачи и плановую дату из выбранного договора
            DataRowView selectedContract = (DataRowView)cmbContract.SelectedItem;
            DateTime issueTime = (DateTime)selectedContract["issue_timestamp"];
            DateTime plannedReturn = (DateTime)selectedContract["planned_return_timestamp"];
            DateTime actualReturn = DateTime.Now;

            // Расчёт часов (округление вверх)
            double hours = (actualReturn - issueTime).TotalHours;
            int hoursRounded = (int)Math.Ceiling(hours);
            if (hoursRounded < 1) hoursRounded = 1;

            decimal total = 0;
            foreach (DataGridViewRow row in dgvContractItems.Rows)
            {
                if (row.IsNewRow) continue;
                decimal price = Convert.ToDecimal(row.Cells["price_per_hour"].Value);
                total += price * hoursRounded;
            }

            // Штраф за просрочку (20% за каждый полный день)
            if (actualReturn > plannedReturn)
            {
                double overdueDays = (actualReturn - plannedReturn).TotalDays;
                int fullDays = (int)Math.Ceiling(overdueDays);
                total += total * 0.2m * fullDays;
            }

            lblTotalCost.Text = $"Итоговая стоимость: {total:C}";
        }

        // 5. Обработчик кнопки "Рассчитать"
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        // 6. Обработчик кнопки "Оформить возврат"
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (cmbContract.SelectedValue == null)
            {
                MessageBox.Show("Выберите договор.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbContract.SelectedValue.ToString(), out int contractId))
            {
                MessageBox.Show("Не удалось определить ID договора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Собираем данные о повреждениях из DataGridView
            var updates = new List<(int itemId, bool damaged, string condition)>();
            foreach (DataGridViewRow row in dgvContractItems.Rows)
            {
                if (row.IsNewRow) continue;
                int itemId = Convert.ToInt32(row.Cells["id"].Value);
                bool damaged = row.Cells["damaged"].Value != null && (bool)row.Cells["damaged"].Value;
                string condition = row.Cells["condition_on_return"].Value?.ToString();
                updates.Add((itemId, damaged, condition));
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("Нет позиций для возврата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime actualReturn = DateTime.Now;

            try
            {
                PerformReturn(contractId, actualReturn, updates);
                MessageBox.Show("Возврат успешно оформлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возврате: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 7. Выполнение транзакции возврата
        private void PerformReturn(int contractId, DateTime actualReturn, List<(int itemId, bool damaged, string condition)> updates)
        {
            using (var conn = new NpgsqlConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Получаем текущую рассчитанную стоимость из метки (или вызываем повторный расчёт)
                        string costText = lblTotalCost.Text.Replace("Итоговая стоимость: ", "").Replace("₽", "").Replace("$", "").Trim();
                        if (!decimal.TryParse(costText, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal totalCost))
                        {
                            totalCost = 0;
                        }

                        // 1. Закрыть договор
                        string updateContract = @"
                            UPDATE RentalContract 
                            SET actual_return_timestamp = @art, total_cost = @cost, status = 'closed' 
                            WHERE id = @cid";
                        using (var cmd = new NpgsqlCommand(updateContract, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("art", actualReturn);
                            cmd.Parameters.AddWithValue("cost", totalCost);
                            cmd.Parameters.AddWithValue("cid", contractId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Обновить позиции договора
                        foreach (var upd in updates)
                        {
                            string updateItem = @"
                                UPDATE ContractItem 
                                SET condition_on_return = @cond, damaged = @dam
                                WHERE id = @itemId";
                            using (var cmd = new NpgsqlCommand(updateItem, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("cond", upd.condition ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("dam", upd.damaged);
                                cmd.Parameters.AddWithValue("itemId", upd.itemId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 3. Обновить статус инвентаря (available/repair) через JOIN
                        foreach (var upd in updates)
                        {
                            string newStatus = upd.damaged ? "repair" : "available";
                            string updateInventory = @"
                                UPDATE Inventory 
                                SET status = @status 
                                FROM ContractItem 
                                WHERE ContractItem.id = @itemId AND Inventory.id = ContractItem.inventory_id";
                            using (var cmd = new NpgsqlCommand(updateInventory, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("status", newStatus);
                                cmd.Parameters.AddWithValue("itemId", upd.itemId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // 8. Кнопка Отмена
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}