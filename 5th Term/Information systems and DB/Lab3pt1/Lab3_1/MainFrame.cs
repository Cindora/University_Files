using Microsoft.Reporting.WinForms;
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

        private void ClassMenuItem_Click(object sender, EventArgs e)
        {
            FormClass frm = new FormClass();
            try
            {
                frm.ShowDialog();
            }
            finally
            {
                frm.Dispose();
            }
        }

        private void mReport_Click(object sender, EventArgs e)
        {
            String pair_beg, pair_end;
            String corp_number;
            String strSql = "";
            // Создание объекта формы задания параметров
            FrmParamRpt frm_par = new FrmParamRpt();
            try
            {
                frm_par.ShowDialog();
                if (frm_par.DialogResult == DialogResult.OK)
                {
                    pair_beg = frm_par.pair1.Text;
                    pair_end = frm_par.pair2.Text;
                    corp_number = frm_par.corpN.Text;
                    // Оператор вызова функции БД
                    strSql += "SELECT * FROM shedule.rpt_pairs(";
                    strSql += pair_beg + ", ";
                    strSql += pair_end + ", ";
                    strSql += corp_number + ")";
                    String con = connectionString;
                    using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql, con))
                    {
                        // Формирование источника данных для отчета
                        DataTable table = new DataTable();
                        dadapter.Fill(table);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = table.DefaultView;
                        // Создание объекта формы вывода отчета
                        FrmRpt frmRpt = new FrmRpt();
                        // Заполнение заголовка
                        frmRpt.Head.Text = "Отчет о занятиях в промежуток с " +
                        pair_beg + " по " + pair_end + " пару.";
                        // Заполнение подзаголовка
                        frmRpt.SubHead.Text = "Номер корпуса:" + corp_number;
                        // Задание шаблона отчета
                        frmRpt.reportViewer1.Reset();
                        frmRpt.reportViewer1.ProcessingMode = ProcessingMode.Local;
                        frmRpt.reportViewer1.LocalReport.ReportPath =
                        AppDomain.CurrentDomain.BaseDirectory + "RptAudit.rdlc";
                        // Задание источника данных отчета
                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "dsRptAudit"; // Имя должно совпадать
                                                         // с именем источника шаблона отчета
                        reportDataSource.Value = table;
                        // вывод отчета
                        frmRpt.reportViewer1.LocalReport.DataSources.Clear();
                        frmRpt.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        frmRpt.reportViewer1.RefreshReport();
                        frmRpt.ShowDialog();
                    } // using
                } // if
            } // try
            finally
            {
                frm_par.Dispose();
            }

        }
    }
}
