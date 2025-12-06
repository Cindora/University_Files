using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetClass._class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.dataSetClass._class);

        }
    }
}
