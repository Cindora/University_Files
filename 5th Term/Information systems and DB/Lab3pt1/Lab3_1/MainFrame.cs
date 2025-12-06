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
    public partial class MainFrame : Form
    {
        public static string connectionString;
        public static OdbcConnection odbcCon;
        public MainFrame()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            FrameConnect frmc = new FrameConnect();
            frmc.edUser.Text = Properties.Settings.Default.Login;
            frmc.edPwd.Text = Properties.Settings.Default.Password;
            Boolean isCon = false; //флаг «Соединение установлено» 
            int k = 1;
            while (k <= 3)
            {
                frmc.ShowDialog();
                if (frmc.DialogResult != DialogResult.OK) break;
                try
                {
                    //DSN-имя созданного источника ODBC! 
                    connectionString = @"DSN=PostgreSQL;Uid=" +
                              frmc.edUser.Text + ";Pwd=" +
                              frmc.edPwd.Text;
                    odbcCon = new OdbcConnection(connectionString);
                    odbcCon.Open();
                    frmc.Close();
                    isCon = true;
                    break;
                }
                catch (System.Data.Odbc.OdbcException ex)
                {
                    if (ex.Message.Contains("проверку подлинности"))
                        MessageBox.Show("Не правильно заданы имя или пароль");
                    else MessageBox.Show("Ошибка:" + ex.Message);
                }
                k++;
            }
            if (!isCon) this.Dispose();// Выход из программы
        }

        private void mSprav_Click(object sender, EventArgs e)
        {
            FormAudit frm = new FormAudit();
            try
            {
                frm.ShowDialog();
            }
            finally
            {
                frm.Dispose();
            }
        }
    }
}
