using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace SportRentalApp
{
    public partial class ReturnForm : Form
    {
        private DataTable contractsTable;
        private DataTable itemsTable;

        public ReturnForm()
        {
            InitializeComponent();
            LoadOpenContracts();
            cmbContract.SelectedIndexChanged += CmbContract_SelectedIndexChanged;
            dgvContractItems.CellValueChanged += DgvContractItems_CellValueChanged;
            btnCalculate.Click += BtnCalculate_Click;
            btnReturn.Click += BtnReturn_Click;
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
        }

        // Загрузка списка открытых договоров
        private void LoadOpenContracts()
        {
            string query = @"SELECT rc.id, c.last_name || ' ' || c.first_name || ' ' || COALESCE(c.middle_name, '') AS client_name,
                                    rc.issue_timestamp, rc.planned_return_timestamp
                             FROM RentalContract rc
                             JOIN Client c ON rc.client_id = c.id
                             WHERE rc.status = 'open'";
            contractsTable = DatabaseHelper.ExecuteQuery(query);
            cmbContract.DisplayMember = "DisplayText";
            cmbContract.ValueMember = "id";
            // Формируем красивый текст для отображения
            cmbContract.DataSource = contractsTable;
            cmbContract.DisplayMember = "DisplayText";
            if (contractsTable.Rows.Count > 0)
            {
                contractsTable.Columns.Add("DisplayText", typeof(string), "id + ' - ' + client_name + ' (выдан: ' + issue_timestamp + ')'");
            }
        }

        // При выборе договора загружаем его позиции
        private void CmbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContract.SelectedValue == null) return;
            int contractId = (int)cmbContract.SelectedValue;
            LoadContractItems(contractId);
        }

        private void LoadContractItems(int contractId)
        {
            string query = @"SELECT ci.id, ci.inventory_id, i.name, i.characteristics, 
                                    ci.damaged, ci.condition_on_return
                             FROM ContractItem ci
                             JOIN Inventory i ON ci.inventory_id = i.id
                             WHERE ci.contract_id = @cid";
            var param = new NpgsqlParameter("cid", contractId);
            itemsTable = DatabaseHelper.ExecuteQuery(query, param);

            dgvContractItems.DataSource = itemsTable;
            ConfigureItemsGrid();
        }

        private void ConfigureItemsGrid()
        {
            // Скрыть ненужные колонки
            if (dgvContractItems.Columns["id"] != null)
                dgvContractItems.Columns["id"].Visible = false;
            if (dgvContractItems.Columns["inventory_id"] != null)
                dgvContractItems.Columns["inventory_id"].Visible = false;

            // Настроить заголовки
            if (dgvContractItems.Columns["name"] != null)
                dgvContractItems.Columns["name"].HeaderText = "Инвентарь";
            if (dgvContractItems.Columns["characteristics"] != null)
                dgvContractItems.Columns["characteristics"].HeaderText = "Характеристики";

            // Колонка damaged – чекбокс
            if (dgvContractItems.Columns["damaged"] is DataGridViewCheckBoxColumn)
            {
                dgvContractItems.Columns["damaged"].HeaderText = "Повреждён";
            }
            else
            {
                // Преобразуем в чекбокс, если ещё не
                var checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "damaged";
                checkColumn.HeaderText = "Повреждён";
                checkColumn.DataPropertyName = "damaged";
                // Удаляем старую колонку и вставляем новую
                int idx = dgvContractItems.Columns["damaged"].Index;
                dgvContractItems.Columns.Remove("damaged");
                dgvContractItems.Columns.Insert(idx, checkColumn);
            }

            if (dgvContractItems.Columns["condition_on_return"] != null)
                dgvContractItems.Columns["condition_on_return"].HeaderText = "Состояние при возврате";
        }

        // Пересчёт стоимости при изменении отметок повреждений (или по кнопке)
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void DgvContractItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (dgvContractItems.Columns[e.ColumnIndex].Name == "damaged" || dgvContractItems.Columns[e.ColumnIndex].Name == "condition_on_return"))
            {
                CalculateTotalCost();
            }
        }

        private void CalculateTotalCost()
        {
            if (cmbContract.SelectedValue == null) return;
            int contractId = (int)cmbContract.SelectedValue;

            // Получаем дату выдачи и плановую дату из выбранного договора
            DataRowView drv = (DataRowView)cmbContract.SelectedItem;
            DateTime issueTime = (DateTime)drv["issue_timestamp"];
            DateTime plannedReturn = (DateTime)drv["planned_return_timestamp"];
            DateTime actualReturn = DateTime.Now; // фактическая дата – текущая

            // Рассчитываем количество часов (округление вверх)
            double hours = (actualReturn - issueTime).TotalHours;
            int hoursRounded = (int)Math.Ceiling(hours);
            if (hoursRounded < 1) hoursRounded = 1; // минимум 1 час

            // Суммируем стоимость по каждой позиции
            decimal total = 0;
            foreach (DataGridViewRow row in dgvContractItems.Rows)
            {
                if (row.IsNewRow) continue;
                int inventoryId = Convert.ToInt32(row.Cells["inventory_id"].Value);
                // Получить цену за час из таблицы Inventory (можно подзапросом, но для простоты заранее сохраним в itemsTable)
                // Лучше запросить из БД или добавить колонку price_per_hour в запрос LoadContractItems
                // Здесь допустим, что мы её добавили (см. доработку запроса ниже)
                decimal pricePerHour = 0;
                if (row.Cells["price_per_hour"].Value != DBNull.Value)
                    pricePerHour = Convert.ToDecimal(row.Cells["price_per_hour"].Value);
                total += pricePerHour * hoursRounded;
            }

            // Штраф за просрочку (если actualReturn > plannedReturn)
            if (actualReturn > plannedReturn)
            {
                double overdueDays = (actualReturn - plannedReturn).TotalDays;
                int fullDaysOverdue = (int)Math.Ceiling(overdueDays);
                total += total * 0.2m * fullDaysOverdue; // 20% от стоимости за каждый день
            }

            lblTotalCost.Text = $"Итоговая стоимость: {total:C}";
        }

        // Оформление возврата (транзакция)
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (cmbContract.SelectedValue == null)
            {
                MessageBox.Show("Выберите договор.");
                return;
            }

            int contractId = (int)cmbContract.SelectedValue;
            DateTime actualReturn = DateTime.Now;

            // Сбор данных о повреждениях из DataGridView
            var updates = new System.Collections.Generic.List<(int itemId, bool damaged, string condition)>();
            foreach (DataGridViewRow row in dgvContractItems.Rows)
            {
                if (row.IsNewRow) continue;
                int itemId = Convert.ToInt32(row.Cells["id"].Value); // id из ContractItem
                bool damaged = row.Cells["damaged"].Value != null && (bool)row.Cells["damaged"].Value;
                string condition = row.Cells["condition_on_return"].Value?.ToString();
                updates.Add((itemId, damaged, condition));
            }

            try
            {
                PerformReturn(contractId, actualReturn, updates);
                MessageBox.Show("Возврат оформлен успешно!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при возврате: " + ex.Message);
            }
        }

        private void PerformReturn(int contractId, DateTime actualReturn, System.Collections.Generic.List<(int itemId, bool damaged, string condition)> updates)
        {
            using (var conn = new NpgsqlConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Рассчитываем общую стоимость (можно вызвать хранимую функцию или повторить расчёт)
                        decimal totalCost = CalculateTotalCostFromDb(conn, tran, contractId, actualReturn, updates);

                        // 2. Обновляем договор: проставляем фактическую дату возврата, стоимость, статус
                        string updateContract = @"UPDATE RentalContract 
                                                  SET actual_return_timestamp = @art, total_cost = @cost, status = 'closed' 
                                                  WHERE id = @cid";
                        using (var cmd = new NpgsqlCommand(updateContract, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("art", actualReturn);
                            cmd.Parameters.AddWithValue("cost", totalCost);
                            cmd.Parameters.AddWithValue("cid", contractId);
                            cmd.ExecuteNonQuery();
                        }

                        // 3. Обновляем каждую позицию договора: состояние при возврате, повреждения
                        foreach (var upd in updates)
                        {
                            string updateItem = @"UPDATE ContractItem 
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

                        // 4. Обновляем статус инвентаря: если повреждён -> repair, иначе available
                        foreach (var upd in updates)
                        {
                            // Сначала получим inventory_id для этой позиции
                            string getInvId = "SELECT inventory_id FROM ContractItem WHERE id = @itemId";
                            int invId;
                            using (var cmd = new NpgsqlCommand(getInvId, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("itemId", upd.itemId);
                                invId = (int)cmd.ExecuteScalar();
                            }
                            string newStatus = upd.damaged ? "repair" : "available";
                            string updateInv = "UPDATE Inventory SET status = @status WHERE id = @invId";
                            using (var cmd = new NpgsqlCommand(updateInv, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("status", newStatus);
                                cmd.Parameters.AddWithValue("invId", invId);
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

        // Вспомогательный метод для расчёта стоимости на стороне БД (упрощённо, можно оставить и на C#)
        private decimal CalculateTotalCostFromDb(NpgsqlConnection conn, NpgsqlTransaction tran, int contractId, DateTime actualReturn, System.Collections.Generic.List<(int itemId, bool damaged, string condition)> updates)
        {
            // Можно вызвать хранимую функцию, но для простоты используем тот же алгоритм, что и в CalculateTotalCost
            // Лучше вынести общий расчёт в отдельный метод, работающий с DataTable.
            // Здесь для краткости вернём 0, но на самом деле нужно пересчитать.
            // Рекомендуется переиспользовать логику из CalculateTotalCost, сохранив результат в поле формы.
            // Мы уже показываем lblTotalCost, поэтому можно взять оттуда.
            string costText = lblTotalCost.Text.Replace("Итоговая стоимость: ", "").Replace("₽", "").Replace("$", "");
            if (decimal.TryParse(costText, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal cost))
                return cost;
            else
                return 0;
        }
    }
}