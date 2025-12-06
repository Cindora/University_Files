using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class FormAudit : Form
    {
        public FormAudit()
        {
            InitializeComponent();
        }

        private void FormAudit_Load(object sender, EventArgs e)
        {
            loadData();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.audit". При необходимости она может быть перемещена или удалена.
            //this.auditTableAdapter.Fill(this.dataSet1.audit);

        }

        private void loadData()
        {
            // Текст оператора запроса
            string strSql = "select * from shedule.audit";
            // Используем строку соединения, заданную при авторизации
            var conStr = MainFrame.connectionString;
            // Используем класс адаптера для получения данных
            // Он будет источником данных для таблицы и навигатора
            using (OdbcDataAdapter dadapter =
            new OdbcDataAdapter(strSql, conStr))
            {
                DataTable table = new DataTable();
                dadapter.Fill(table);
                BindingSource bs = new BindingSource();
                bs.DataSource = table.DefaultView;
                this.bnavAudit.BindingSource = bs;
                this.dgAudit.DataSource = bs;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить строку?", "Удаление", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.OK) return;
            // Определяем индекс текущей строки
            int ind = dgAudit.CurrentCell.RowIndex;
            // Определяем ключ удаляемой строки (колонка с индексом 0)
            string key = dgAudit.Rows[ind].Cells[0].Value.ToString();
            // Формирование запроса удаления строки
            string strSql = "";
            strSql += "DELETE FROM shedule.audit";
            strSql += " WHERE audit_number=" + key;
            // Используем соединение, полученное при авторизации
            OdbcConnection con = MainFrame.odbcCon;
            // Создание объекта запроса
            OdbcCommand cmd = new OdbcCommand(strSql, con);
            // Выполнение запроса
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки \n" + ex.Message);
                return;
            }
            // Перегружаем данные таблицы
            loadData();
            // Устанавливаем курсор таблицы на предыдущую строку
            if (ind > 0) ind--;
            dgAudit.CurrentCell = dgAudit[0, ind];
        }

        private void sbAdd_Click(object sender, EventArgs e)
        {
            FormEdAudit frm = new FormEdAudit(true, "");
            // Заголовок формы в режиме добавления нового поставщика
            frm.Text = "Добавление аудитории";
            frm.ShowDialog();
            // Перегружаем данные в случае добавления новой строки
            if (frm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
            frm.Dispose();
        }

        private void sbEdit_Click(object sender, EventArgs e)
        {
            // Запоминаем номер текущей строки
            int ind = dgAudit.CurrentCell.RowIndex;
            // Создаем форму (второй параметр – ключ редактируемой строки)
            FormEdAudit frm = new FormEdAudit(false, dgAudit.Rows[ind].Cells[0].Value.ToString());
            // Заголовок формы в режиме редактирования
            frm.Text = "Редактирование аудитории";
            // Заполняем поля ввода текущими значениями
            frm.edAudit.Text = dgAudit.Rows[ind].Cells[0].Value.ToString();
            frm.edCorps.Text = dgAudit.Rows[ind].Cells[1].Value.ToString();
            frm.cbFloor.Text = dgAudit.Rows[ind].Cells[2].Value.ToString();
            frm.ShowDialog();
            // Перегружаем данные в случае сохранения изменений
            if (frm.DialogResult == DialogResult.OK)
            {
                loadData();
                dgAudit.CurrentCell = dgAudit[0, ind];
            }
            frm.Dispose();
        }
    }
}
