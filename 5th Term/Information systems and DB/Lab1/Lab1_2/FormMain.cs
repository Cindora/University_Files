using System;

namespace Lab1_2
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        int[] Xn, Zn;
        int countXFour = 0, countNegative = 0, lenXn, lenZn;
        string[] inputArr;

        public FormMain()
        {
            InitializeComponent();
            gridXn.AllowUserToAddRows = false;
            gridZn.AllowUserToAddRows = false;

            panelTwo.Visible = false;
            panelThree.Visible = false;

            textResult.Enabled = false;
        }

        private void button1EnterN_Click(object sender, EventArgs e)
        {
            // get lenXn
            if (Int32.TryParse(textN.Text, out lenXn))
            {
                if (lenXn > 0)
                {
                    panelOne.Enabled = false;
                    panelTwo.Visible = true;
                }
                else
                    textN.Text = "";
            }
            else
                textN.Text = "";
            //

            // Xn settings
            gridXn.Rows.Clear();
            gridXn.ColumnCount = lenXn;
            gridXn.RowCount = 1;
            for (int i = 0; i < lenXn; i++)
            {
                gridXn.Columns[i].HeaderText = "Xn[" + i.ToString() + "]";
            }
            //
        }

        private void button2Calculate_Click(object sender, EventArgs e)
        {
            // Read Xn
            Xn = new int[lenXn];

            for (int i = 0; i < lenXn; i++)
            {
                Xn[i] = Convert.ToInt32(gridXn.Rows[0].Cells[i].Value);
                if (Xn[i] % 4 == 0) // the number of elements multiples of four
                    countXFour++;
                if (Xn[i] < 0) // the number of elements less than zero
                    countNegative++;
            }
            lenZn = countNegative;
            //

            textResult.Text = countXFour.ToString(); // Text result div by 4

            // Construct Zn
            if (lenZn > 0)
            {
                gridZn.ColumnCount = lenZn;
                gridZn.RowCount = 1;
                for (int i = 0; i < lenZn; i++)
                {
                    gridZn.Columns[i].HeaderText = "Zn[" + i.ToString() + "]";
                }

                Zn = new int[lenZn];
                int j = 0;
                foreach (int el in Xn)
                    if (el < 0)
                    {
                        Zn[j] = el * el;
                        gridZn.Rows[0].Cells[j].Value = Zn[j];
                        j++;
                    }
            }
            else
            {
                gridZn.ColumnCount = 1;
                gridZn.RowCount = 0;
                gridZn.Columns[0].HeaderText = "Массив не сформирован.";
            }
            //

            panelTwo.Enabled = false;
            panelThree.Visible = true;            
        }

        private void button2BackToEnterN_Click(object sender, EventArgs e)
        {
            panelOne.Enabled = true;
            panelTwo.Visible = false;
        }

        private void button3BackToEnterXn_Click(object sender, EventArgs e)
        {
            countXFour = 0; countNegative = 0;

            panelTwo.Enabled = true;
            panelThree.Visible = false;
        }
    }
}
