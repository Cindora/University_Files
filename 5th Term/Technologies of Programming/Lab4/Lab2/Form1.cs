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

/*
Создайте класс Чай с полями название, сорт, цена. 
Реализуйте метод расчета скидки, который вычисляет размер скидки на чай в зависимости от его цены. 
Затем создайте два класса, наследуемых от класса Чай: 
Чай в пакетиках с дополнительным полем количество пакетиков и 
Чай в банке с дополнительным полем вес. 
Переопределите метод рассчитать скидку хотя бы в одном из этих классов.
*/

namespace Lab2
{
    
    // Основная форма приложения
    public partial class Form1 : Form
    {
        List<TeaBags> teaBagsList = new List<TeaBags>();
        List<TeaJar> teaJarList = new List<TeaJar>();

        public Form1()
        {
            InitializeComponent();

            // Инициализация данных
            teaBagsList.Add(new TeaBags("Ахмад", "Чёрный", 150, 25));
            teaBagsList.Add(new TeaBags("Lipton", "Зелёный", 180, 20));
            teaBagsList.Add(new TeaBags("Greenfield", "Фруктовый", 120, 30));

            teaJarList.Add(new TeaJar("Dilmah", "Чёрный", 600, 100));
            teaJarList.Add(new TeaJar("Tess", "Зелёный", 450, 80));
            teaJarList.Add(new TeaJar("Akbar", "Чёрный", 700, 120));

            dataGridView1.DataSource = teaBagsList;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Discount",
                HeaderText = "Discount",
                ReadOnly = true
            });

            dataGridView2.DataSource = teaJarList;
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Discount",
                HeaderText = "Discount",
                ReadOnly = true
            });
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
    
            for (int i = 0; i < teaBagsList.Count; i++)
            {
                decimal discount = teaBagsList[i].CalculateDiscount();
                dataGridView1.Rows[i].Cells["Discount"].Value = discount.ToString("C");
            }

            for (int i = 0; i < teaJarList.Count; i++)
            {
                decimal discount = teaJarList[i].CalculateDiscount();
                dataGridView2.Rows[i].Cells["Discount"].Value = discount.ToString("C");
            }
        }
    }

    // Базовый класс Чай
    public class Tea
    {
        public string Name { get; set; }
        public string Sort { get; set; }
        public decimal Price { get; set; }

        public Tea(string name, string sort, decimal price)
        {
            Name = name;
            Sort = sort;
            Price = price;
        }

        public virtual decimal CalculateDiscount()
        {
            return Price * 0.05m;
        }
    }

    // Класс Чай в пакетиках
    public class TeaBags : Tea
    {
        public int BagCount { get; set; }

        public TeaBags(string name, string sort, decimal price, int bagCount)
            : base(name, sort, price)
        {
            BagCount = bagCount;
        }

    }

    // Класс Чай в банке с переопределённым расчётом скидки
    public class TeaJar : Tea
    {
        public int Weight { get; set; }

        public TeaJar(string name, string sort, decimal price, int weight)
            : base(name, sort, price)
        {
            Weight = weight;
        }

        public override decimal CalculateDiscount()
        {
            // Высокая скидка для дорогих позиций
            if (Price > 500)
                return Price * 0.15m; // 15% скидка
            else
                return Price * 0.1m;  // 10% скидка
        }
    }


}
