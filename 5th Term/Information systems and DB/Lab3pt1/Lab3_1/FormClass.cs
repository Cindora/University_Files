using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class FormClass : Form
    {
        private string strSql;
        public FormClass()
        {
            InitializeComponent();
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string strSql = "select * from shedule.audit";

            // Получение строки соединения из главной формы
            var con = MainFrame.connectionString;
            using (OdbcDataAdapter dadapter =
            new OdbcDataAdapter(strSql, con))
            {
                // Загрузка таблицы
                DataTable table = new DataTable();
                dadapter.Fill(table);
                // Синхронизация табличного элемента и навигатора
                BindingSource bs = new BindingSource();
                bs.DataSource = table.DefaultView;
                this.bnClass.BindingSource = bs;
                this.dgClass.DataSource = bs;
            }
        }

        private void sbDel_Click(object sender, EventArgs e)
        {
            // Подтверждение удаления строки
            DialogResult dr = MessageBox.Show("Удалить строку?",
            "Confirmation", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (dr != DialogResult.OK) return;
            // Определение индекса выделенной строки
            int ind = dgClass.CurrentCell.RowIndex;
            // Определение ключа (в первой колонке таблицы)
            string key = dgClass.Rows[ind].Cells[0].Value.ToString();
            // Формирование оператора SQL удаления строки
            string strSqlDel = "";
            strSqlDel += "DELETE FROM shedule.audit ";
            strSqlDel += " WHERE class_id=" + key;
            // Используем объект установленного соединения
            OdbcConnection con = MainFrame.odbcCon;
            OdbcCommand cmd = new OdbcCommand(strSqlDel, con);
            try
            {
                // Выполнение оператора SQL
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки \n" + ex.Message);
                return;
            }
            // Обновление источника данных
            loadData();
            // Делаем текущей предыдущую строку
            if (ind > 0) ind--;
            dgClass.CurrentCell = dgClass[1, ind];
        }
    }
}
