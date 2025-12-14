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
        string strSql = "select class_id, week_day, " +
            "pair_number, group_number," +
            "subject, lesson_type, capacity, students_number, " +
            "audit_number from shedule.classs";
        public FormClass()
        {
            InitializeComponent();
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            loadData(strSql);
        }
        private void loadData(string strSql)
        {
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
            strSqlDel += "DELETE FROM shedule.class ";
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
            loadData(strSql);
            // Делаем текущей предыдущую строку
            if (ind > 0) ind--;
            dgClass.CurrentCell = dgClass[1, ind];
        }

        private void sbAdd_Click(object sender, EventArgs e)
        {
            FormEdClass frm = new FormEdClass(true, "");
            // Заголовок формы в режиме добавления нового поставщика
            frm.Text = "Добавление занятия";
            frm.ShowDialog();
            // Перегружаем данные в случае добавления новой строки
            if (frm.DialogResult == DialogResult.OK)
            {
                loadData(strSql);
            }
            frm.Dispose();
        }

        private void sbEdit_Click(object sender, EventArgs e)
        {
            // Запоминаем номер текущей строки
            int ind = dgClass.CurrentCell.RowIndex;
            // Создаем форму (второй параметр – ключ редактируемой строки)
            FormEdClass frm = new FormEdClass(false, dgClass.Rows[ind].Cells[0].Value.ToString());
            // Заголовок формы в режиме редактирования
            frm.Text = "Редактирование занятия";
            // Заполняем поля ввода текущими значениями
            
            frm.cbWeekDay.Text = dgClass.Rows[ind].Cells[1].Value.ToString();
            frm.edPairNumber.Text = dgClass.Rows[ind].Cells[2].Value.ToString();
            frm.edGroupNum.Text = dgClass.Rows[ind].Cells[3].Value.ToString();
            frm.edSubject.Text = dgClass.Rows[ind].Cells[4].Value.ToString();
            frm.cbLessonType.Text = dgClass.Rows[ind].Cells[5].Value.ToString();
            frm.edCapacity.Text = dgClass.Rows[ind].Cells[6].Value.ToString();
            frm.edNumOfStudents.Text = dgClass.Rows[ind].Cells[7].Value.ToString();
            frm.cbAudit.Text = dgClass.Rows[ind].Cells[8].Value.ToString();

            
            frm.ShowDialog();
            // Перегружаем данные в случае сохранения изменений
            if (frm.DialogResult == DialogResult.OK)
            {
                loadData(strSql);
                dgClass.CurrentCell = dgClass[1, ind];
            }
            frm.Dispose();
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {

        }
        private void bFilter_Click(object sender, EventArgs e)
        {
            string where = "";
            string str;

            if (edDay.Text != string.Empty) 
            {
                where += " and week_day ilike '%" + edDay.Text + "%'"; 
            }
            if (edPair.Text != string.Empty)
            {
                where += " and pair_number ilike '%" + edPair.Text + "%'";
            }
            if (edGroup.Text != string.Empty)
            {
                where += " and group_number ilike '%" + edGroup.Text + "%'";
            }
            if (edSubject.Text != string.Empty)
            {
                where += " and subject ilike '%" + edSubject.Text + "%'";
            }
            if (edType.Text != string.Empty)
            {
                where += " and lesson_type ilike '%" + edType.Text + "%'";
            }
            if (edAudit.Text != string.Empty)
            {
                where += " and audit_number ilike '%" + edAudit.Text + "%'";
            }
            if (edCap1.Text != string.Empty)
            {
                where += " and capacity>= " + edCap1.Text;
            }
            if (edCap2.Text != string.Empty)
            {
                where += " and capacity<= " + edCap2.Text;
            }
            if (edNum1.Text != string.Empty)
            {
                where += " and students_number>= " + edNum1.Text;
            }
            if (edNum2.Text != string.Empty)
            {
                where += " and students_number<= " + edNum2.Text;
            }

            if (where == "")
                str = "select * from shedule.classs";
            else
                str = "select * from shedule.classs WHERE 1 = 1 "
                    + where + " ORDER BY class_id";
            loadData(str);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            edDay.Text = string.Empty;
            edPair.Text = string.Empty;
            edGroup.Text = string.Empty;
            edSubject.Text = string.Empty;
            edType.Text = string.Empty;
            edCap1.Text = string.Empty;
            edCap2.Text = string.Empty;
            edNum1.Text = string.Empty;
            edNum2.Text = string.Empty;
            edAudit.Text = string.Empty;
            loadData(strSql);
        }

    }
}
