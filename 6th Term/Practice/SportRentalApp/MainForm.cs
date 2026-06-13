using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace SportRentalApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            string query = "SELECT id, last_name, first_name, middle_name, phone, passport_data FROM Client";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvClients.DataSource = dt;
            dgvClients.Columns["id"].Visible = false; // скрываем ID
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (var form = new AddClientForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string query = @"INSERT INTO Client (last_name, first_name, middle_name, phone, passport_data) 
                             VALUES (@ln, @fn, @mn, @ph, @pass)";
                    var p1 = new NpgsqlParameter("ln", form.LastName);
                    var p2 = new NpgsqlParameter("fn", form.FirstName);
                    var p3 = new NpgsqlParameter("mn", form.MiddleName ?? (object)DBNull.Value);
                    var p4 = new NpgsqlParameter("ph", form.Phone);
                    var p5 = new NpgsqlParameter("pass", form.Passport);
                    DatabaseHelper.ExecuteNonQuery(query, p1, p2, p3, p4, p5);
                    LoadClients(); // обновить DataGridView с клиентами
                }
            }
        }

        private void btnShowAvailable_Click(object sender, EventArgs e)
        {
            string selectedType = cmbEquipmentType.SelectedItem.ToString(); // "лыжи" или "велосипеды"
            string query = @"SELECT i.id, i.name, i.characteristics, i.price_per_hour, i.deposit_amount
                     FROM Inventory i
                     JOIN EquipmentType et ON i.equipment_type_id = et.id
                     WHERE et.name = @type AND i.status = 'available'";
            var param = new NpgsqlParameter("type", selectedType);
            DataTable dt = DatabaseHelper.ExecuteQuery(query, param);
            dgvInventory.DataSource = dt;
            dgvInventory.Columns["id"].Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (var form = new ReturnForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Обновить таблицы, если нужно
                    // LoadAvailableInventory();   // обновить доступный инвентарь
                    // LoadActiveContracts();      // если есть такой метод
                }
            }
        }

        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;
            string query = @"SELECT SUM(total_cost) AS revenue 
                     FROM RentalContract 
                     WHERE status = 'closed' 
                       AND actual_return_timestamp BETWEEN @s AND @e";
            var p1 = new NpgsqlParameter("s", start);
            var p2 = new NpgsqlParameter("e", end);
            object result = DatabaseHelper.ExecuteQuery(query, p1, p2).Rows[0][0];
            decimal revenue = (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);
            MessageBox.Show($"Выручка за период: {revenue:C}");
        }

        private void btnOverdueReport_Click(object sender, EventArgs e)
        {
            string query = @"SELECT rc.id, c.last_name, c.first_name, rc.planned_return_timestamp
                     FROM RentalContract rc
                     JOIN Client c ON rc.client_id = c.id
                     WHERE rc.status = 'open' AND rc.planned_return_timestamp < NOW()";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            // показать в отдельной DataGridView
        }
    }
}

