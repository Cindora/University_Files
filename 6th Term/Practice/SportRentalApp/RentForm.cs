using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace SportRentalApp
{
    public partial class RentForm : Form
    {
        private DataTable availableInventoryTable;
        private List<int> selectedInventoryIds = new List<int>();

        public RentForm()
        {
            InitializeComponent();
            LoadClients();
            LoadAvailableInventory();
            dgvAvailableInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableInventory.MultiSelect = true; // можно выбрать несколько строк
        }

        private void LoadClients()
        {
            string query = "SELECT id, last_name || ' ' || first_name || ' ' || COALESCE(middle_name, '') AS fullname, phone FROM Client";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            cmbClient.DisplayMember = "fullname";
            cmbClient.ValueMember = "id";
            cmbClient.DataSource = dt;
        }

        public void LoadAvailableInventory()
        {
            string query = @"SELECT i.id, i.name, i.characteristics, i.price_per_hour, i.deposit_amount
                             FROM Inventory i
                             WHERE i.status = 'available'";
            availableInventoryTable = DatabaseHelper.ExecuteQuery(query);
            dgvAvailableInventory.DataSource = availableInventoryTable;
            dgvAvailableInventory.Columns["id"].Visible = false; // скрыть колонку ID
        }

        private void dgvAvailableInventory_SelectionChanged(object sender, EventArgs e)
        {
            selectedInventoryIds.Clear();
            foreach (DataGridViewRow row in dgvAvailableInventory.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                selectedInventoryIds.Add(id);
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента.");
                return;
            }
            if (selectedInventoryIds.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну единицу инвентаря.");
                return;
            }
            if (dtpPlannedReturn.Value <= DateTime.Now)
            {
                MessageBox.Show("Плановая дата возврата должна быть позже текущего времени.");
                return;
            }

            int clientId = (int)cmbClient.SelectedValue;
            DateTime plannedReturn = dtpPlannedReturn.Value;

            // Выполняем выдачу (транзакция)
            try
            {
                PerformRent(clientId, selectedInventoryIds, plannedReturn);
                MessageBox.Show("Выдача оформлена успешно!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при оформлении выдачи: " + ex.Message);
            }
        }

        private void PerformRent(int clientId, List<int> inventoryIds, DateTime plannedReturn)
        {
            using (var conn = new NpgsqlConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Создать договор
                        string insertContract = @"INSERT INTO RentalContract 
                                                 (client_id, issue_timestamp, planned_return_timestamp, status) 
                                                 VALUES (@cid, NOW(), @pr, 'open') RETURNING id";
                        long contractId;
                        using (var cmd = new NpgsqlCommand(insertContract, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("cid", clientId);
                            cmd.Parameters.AddWithValue("pr", plannedReturn);
                            contractId = (long)cmd.ExecuteScalar();
                        }

                        // 2. Для каждого инвентаря – вставить позицию и изменить статус
                        foreach (int invId in inventoryIds)
                        {
                            string insertItem = @"INSERT INTO ContractItem (contract_id, inventory_id, condition_on_issue) 
                                                  VALUES (@cid, @iid, 'Без замечаний')";
                            using (var cmd = new NpgsqlCommand(insertItem, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("cid", contractId);
                                cmd.Parameters.AddWithValue("iid", invId);
                                cmd.ExecuteNonQuery();
                            }

                            string updateInv = "UPDATE Inventory SET status = 'rented' WHERE id = @iid";
                            using (var cmd = new NpgsqlCommand(updateInv, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("iid", invId);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}