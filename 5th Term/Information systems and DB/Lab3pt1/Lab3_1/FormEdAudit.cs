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
using System.Xml.Linq;

namespace Lab3_1
{
    public partial class FormEdAudit : Form
    {
        private bool isNew = true;
        private String old_key;

        public FormEdAudit(bool isNew, String old_key)
        {
            this.isNew = isNew;
            this.old_key = old_key;
            InitializeComponent();
        }

        private void FormEdAudit_Load(object sender, EventArgs e)
        {

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
                strSql += "INSERT INTO shedule.audit(audit_number,corps_number,floor) values(";
                strSql += edAudit.Text;
                strSql += ",'" + edCorps.Text + "'";
                strSql += ",'" + cbFloor.Text + "')";
            }
            else
            {
                strSql += "UPDATE shedule.audit SET ";
                strSql += "audit_number=" + edAudit.Text;
                strSql += ",corps_number='" + edCorps.Text + "'";
                strSql += ",floor='" + cbFloor.Text + "'";
                strSql += " WHERE audit_number=" + old_key;
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
