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
            LoadClients();              // загрузка клиентов (если есть DataGridView для клиентов)
            LoadInventory();   // загрузка доступного инвентаря
            txtClientSearch.TextChanged += TxtClientSearch_TextChanged;

        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    LoadClients();
        //}

        private void LoadClients()
        {
            string query = "SELECT id, last_name, first_name, middle_name, phone, passport_data FROM Client";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvClients.DataSource = dt;
            dgvClients.Columns["id"].Visible = false; // скрываем ID
            // Настройка заголовков
            dgvClients.Columns["last_name"].HeaderText = "Фамилия";
            dgvClients.Columns["first_name"].HeaderText = "Имя";
            dgvClients.Columns["middle_name"].HeaderText = "Отчество";
            dgvClients.Columns["phone"].HeaderText = "Телефон";
            dgvClients.Columns["passport_data"].HeaderText = "Номер паспорта";
        }

        private void LoadInventory()
        {
            string query = @"SELECT i.id, i.name, i.characteristics, i.price_per_hour, i.deposit_amount
                             FROM Inventory i
                             WHERE i.status = 'available'";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvInventory.DataSource = dt;
            if (dgvInventory.Columns["id"] != null)
                dgvInventory.Columns["id"].Visible = false;
            // Настройка заголовков
            dgvInventory.Columns["name"].HeaderText = "Наименование";
            dgvInventory.Columns["characteristics"].HeaderText = "Характеристики";
            dgvInventory.Columns["price_per_hour"].HeaderText = "Цена/час";
            dgvInventory.Columns["deposit_amount"].HeaderText = "Залог";
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
                    try
                    {
                        DatabaseHelper.ExecuteNonQuery(query, p1, p2, p3, p4, p5);
                        LoadClients();
                        MessageBox.Show("Клиент успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (PostgresException ex) when (ex.SqlState == "23505")
                    {
                        // Код 23505 – нарушение уникальности (дубликат паспорта)
                        MessageBox.Show("Клиент с таким номером паспорта уже существует. Добавление отклонено.",
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (PostgresException ex)
                    {
                        MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnShowAvailable_Click(object sender, EventArgs e)
        {
            string selectedType = cmbEquipmentType.SelectedItem.ToString(); // "лыжи" или "велосипед"
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
                    // Обновить таблицы
                    LoadInventory();
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

        private void btnRent_Click(object sender, EventArgs e)
        {
            using (var form = new RentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // После успешной выдачи обновляем таблицы, если нужно
                    LoadInventory(); // обновить список доступного инвентаря
                }
            }
        }

        private void TxtClientSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtClientSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // Если строка поиска пуста, загружаем всех клиентов
                LoadClients();
            }
            else
            {
                // Ищем по телефону или паспорту (частичное совпадение)
                string query = @"SELECT id, last_name, first_name, middle_name, phone, passport_data 
                         FROM Client 
                         WHERE phone LIKE @search OR passport_data LIKE @search";
                var param = new NpgsqlParameter("search", "%" + searchText + "%");
                DataTable dt = DatabaseHelper.ExecuteQuery(query, param);
                dgvClients.DataSource = dt;
                if (dgvClients.Columns["id"] != null)
                    dgvClients.Columns["id"].Visible = false;
            }
        }
    }
}

