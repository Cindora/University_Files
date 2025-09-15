using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadTeaTable();
        }

        private void LoadTeaTable()
        {
            Tea[] teaArr = new Tea[] // Массив объектов Tea
            {
            new Tea("Черный", "Цейлон", 110),
            new Tea("Черный", "Санрайз", 150),
            new Tea("Зелёный", "Драгон", 220),
            new Tea("Травяной", "Разнотравье", 250),
            new Tea("Китайский", "Пуэр", 330),
            new Tea("Китайский", "Улун", 350)
            };
            
            tableTea.DataSource = teaArr;

            tableTea.Columns["Name"].HeaderText = "Название";
            tableTea.Columns["Sort"].HeaderText = "Сорт";
            tableTea.Columns["Price"].HeaderText = "Цена";
        }

        public class Tea
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
        }

    }
}
