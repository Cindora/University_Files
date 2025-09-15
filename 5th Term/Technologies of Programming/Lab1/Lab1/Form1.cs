using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonB.Left <= 0)
                buttonB.Left = ClientSize.Width - buttonB.Width;
            else
                buttonB.Left -= 10;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (buttonA.Left >= ClientSize.Width - buttonA.Width )
                buttonB.Left = 0;
            else
                buttonA.Left += 10;
        }
    }
}
