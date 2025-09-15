using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Tea[] arrTea;
        int numTea = 0;
        bool[] isFilled = {false, false };
        public Form1()
        {
            InitializeComponent();

            arrTea = new Tea[2];
            radioButtonNumber1.Checked = true;
            textSelected.Enabled = false;
            textPriseWithDiscount.Enabled = false;
        }

        private void buttonInput_Click(object sender, EventArgs e) // Ввод
        {
            int price;


            if (Int32.TryParse(textPrice.Text, out price))
            {
                if (price > 0)
                {
                    arrTea[numTea] = new Tea(textName.Text, textSort.Text, price);
                    isFilled[numTea] = true;
                }
                else
                    blankNSP();
            }
            else
                blankNSP();
        }

        private void blankNSP() // Очистить Имя, Сорт, Цена
        {
            textName.Text = "";
            textSort.Text = "";
            textPrice.Text = "";

            isFilled[numTea] = false;
        }

        private void buttonCalcPriceWithDisc_Click(object sender, EventArgs e) // Цена со скидкой
        {
            int discount = 0;

            if (Int32.TryParse(textDiscount.Text, out discount))
            {
                if (discount >= 0 && discount <= 100)
                {
                    if (isFilled[numTea])
                    {
                        textPriseWithDiscount.Text = 
                            arrTea[numTea].CalculatePriceWithDiscount(discount).ToString();
                    }
                    else
                    {
                        textPriseWithDiscount.Text = "Поле Цена пусто.";
                    }
                }
                else
                {
                    textDiscount.Text = "";
                    textPriseWithDiscount.Text = "";
                }
            }
            else
            {
                textDiscount.Text = "";
                textPriseWithDiscount.Text = "";
            }
        }

        private void radioButtonNumber1_CheckedChanged(object sender, EventArgs e) // #1
        {
            radioClicked(0);
        }

        private void radioButtonNumber2_CheckedChanged(object sender, EventArgs e) // #2
        {
            radioClicked(1);
        }

        private void radioClicked(int numberTea) // #1 или #2
        {
            numTea = numberTea;

            textSelected.Text = "№ " + (numTea + 1).ToString();

            if (isFilled[numTea])
            {
                textName.Text = arrTea[numTea].Name;
                textSort.Text = arrTea[numTea].Sort;
                textPrice.Text = arrTea[numTea].Price.ToString();
            }
            else
                blankNSP();
        }
    }

    public class Tea // Класс Чай
    {
        public string Name { get; set; }
        public string Sort { get; set; }
        public int Price { get; set; }

        public Tea(string name, string sort, int price)
        {
            Name = name;
            Sort = sort;
            Price = price;
        }

        public int CalculatePriceWithDiscount(int discount)
        {
            return Price * (100 - discount) / 100;
        }
    }
}
