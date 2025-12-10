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
    public partial class FormEdClass : Form
    {
        private bool isNew = true; // Флаг режима добавления новой строки
        private String old_key; // Ключ (для режима редактирования)

        public FormEdClass(bool isNew, String old_key)
        {
            this.isNew = isNew;
            this.old_key = old_key;
            InitializeComponent();
        }

        private void FormEdClass_Load(object sender, EventArgs e)
        {
            loadData();
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
                
                cbAudit.DataSource = table;
                cbAudit.DisplayMember = "audit_number";// столбец для отображения
                cbAudit.ValueMember = "audit_number";
            }
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            string strSql = "";
            if (isNew)
            {
                strSql += "INSERT INTO shedule.Class(week_day,pair_number," +
                    "group_number,subject,lesson_type,capacity,students_number,audit_number) values(";
                strSql += "'" + cbWeekDay.Text + "'";
                strSql += "," + edPairNumber.Text;
                strSql += ",'" + edGroupNum.Text + "'";
                strSql += ",'" + edSubject.Text + "'";
                strSql += ",'" + cbLessonType.Text + "'";
                strSql += "," + edCapacity.Text;
                strSql += "," + edNumOfStudents.Text;
                strSql += "," + cbAudit.Text + ")";
            }
            else
            {
                strSql += "UPDATE shedule.Class SET ";
                strSql += "week_day='" + cbWeekDay.Text + "'";
                strSql += ",pair_number=" + edPairNumber.Text;
                strSql += ",group_number='" + edGroupNum.Text + "'";
                strSql += ",subject='" + edSubject.Text + "'";
                strSql += ",lesson_type='" + cbLessonType.Text + "'";
                strSql += ",capacity=" + edCapacity.Text;
                strSql += ",students_number=" + edNumOfStudents.Text;
                strSql += ",audit_number=" + cbAudit.Text;
                strSql += " WHERE class_id=" + old_key;
            }
            String conStr = MainFrame.connectionString;
            OdbcConnection con = MainFrame.odbcCon;
            OdbcCommand cmd = new OdbcCommand(strSql, con);
            try
            {
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления/изменения строки \n" +
                ex.Message);
                return;
            }
        }
    }
}
