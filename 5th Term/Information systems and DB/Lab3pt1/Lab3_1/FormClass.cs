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
    }
}
