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
    public partial class Form1 : Form
    {
        Tea[] arrTea;
        int numTea = 0;
        bool[] isFilled = {false, false };
        public Form1()
        {
            InitializeComponent();
            LoadTeaTable();
        }

        private void LoadTeaTable()
        {
            TeaBagged[] teaArr = new TeaBagged[] // Массив объектов Tea
            {
            new TeaBagged("Черный", "Цейлон", 110),
            new TeaBagged("Черный", "Санрайз", 150),
            new TeaBagged("Зелёный", "Драгон", 220),
            };

            tableTea.DataSource = teaArr;

            tableTea.Columns["Name"].HeaderText = "Название";
            tableTea.Columns["Sort"].HeaderText = "Сорт";
            tableTea.Columns["Price"].HeaderText = "Цена";
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

        public virtual int CalculatePriceWithDiscount(int discount)
        {
            return Price * (100 - discount) / 100;
        }
    }

    public class TeaBagged : Tea // Пакетированный
    {
        public int PacketCount { get; set; }

        public TeaBagged(string name, string sort, int price, int packetCount)
            : base(name, sort, price)
        {
            PacketCount = packetCount;
        }
    }

    public class TeaJar : Tea // Чай в банке
    {
        public int WeightGrams { get; set; } // Вес в граммах

        public TeaJar(string name, string sort, int price, int weightGrams)
            : base(name, sort, price)
        {
            WeightGrams = weightGrams;
        }

        public override int CalculatePriceWithDiscount(int discount)
        {
            return Price * (100 - discount - (WeightGrams/100)) / 100 - WeightGrams / 50;
        }
    }
}
