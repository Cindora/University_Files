using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class MainForm : Form
    {
        // Класс "Адрес"
        public class Address
        {
            public string City;
            public string Street;
            public int HouseNumber;

            public override string ToString()
            {
                return $"{City}, {Street}, {HouseNumber}";
            }

            public Address (string city, string street, int houseNumber)
            {
                City = city;
                Street = street;
                HouseNumber = houseNumber;
            }
        }

        // Исходный массив адресов
        private Address[] addresses;

        public MainForm()
        {
            InitializeComponent();

            // Создаём пример массива
            addresses = new Address[]
            {
                new Address ("Москва", "Ленина", 12),
                new Address ("Москва", "Ленина", 15),
                new Address ("Москва", "Ленина", 12),
                new Address ("Москва", "Ленина", 12),
                new Address ("Москва", "Арбат", 15),
                new Address ("Москва", "Арбат", 15),
                new Address ("Казань", "Баумана", 3),
                new Address ("Краснодар", "Морская", 8)
            };

            txtInput.Text = string.Join(Environment.NewLine, addresses.Select(a => a.ToString()));
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            var groups = addresses
                .GroupBy(a => a.Street)
                .Select(g => new { Street = g.Key, Items = g.ToList() });

            foreach (var group in groups)
            {
                txtOutput.Text += ("Улица " + group.Street + ":");
                foreach (var a in group.Items)
                {
                    txtOutput.Text += (Environment.NewLine + "  " + a.ToString());
                }
                txtOutput.Text += Environment.NewLine + Environment.NewLine;
            }
        }

        private void btnDuplicates_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            var duplicates = addresses
                .GroupBy(a => new { a.City, a.Street, a.HouseNumber })
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            if (duplicates.Any())
                foreach (var a in duplicates)
                    txtOutput.Text += ($"{a.City}, ул. {a.Street}, дом {a.HouseNumber}" + Environment.NewLine);
            else 
                txtOutput.Text += ("Повторяющихся адресов нет.");
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            var odd = addresses
                .Where(a => a.HouseNumber % 2 != 0)
                .Select(a => $"{a.City}, ул. {a.Street}, дом {a.HouseNumber}");

            if (odd.Any())
                foreach (var s in odd)
                    txtOutput.Text += s + Environment.NewLine;
            else
                txtOutput.Text += ("Нет адресов с нечётными номерами домов.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
