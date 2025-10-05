using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
            chart1 = new Chart() { Location = new Point(20, 70), Width = 600, Height = 320 };
            chart1.ChartAreas.Add(new ChartArea("Main"));

            Controls.AddRange(new Control[] { chart1 });
        }

        private Chart chart1;


        private void btnBars_Click_1(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            int a = 5, c = 50;

            ADataProvider randData = new RandomDataProvider(a, c);
            var data = randData.GetData();

            AChartRenderer renderer = new BarChartRenderer();
            renderer.DrawChart(data, chart1);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            AFunk func = new SinFunction();
            func.Plot(chart1, -10, 10, 0.1);
        }
    }

    // // Абстрактные классы

    public abstract class ADataProvider
    {
        public abstract List<double> GetData();
    }

    public abstract class AChartRenderer
    {
        public abstract void DrawChart(List<double> data, Chart chart);
    }

    public abstract class AFunk
    {
        public abstract void Plot(Chart chart, double xMin, double xMax, double dx);
    }

    // // Реализация 
    
    // Генерация чисел
    public class RandomDataProvider : ADataProvider
    {
        private int a, c;
        public RandomDataProvider(int a, int c)
        {
            this.a = a;
            this.c = c;
        }

        public override List<double> GetData()
        {
            Random rnd = new Random();
            List<double> numbers = new List<double>();
            for (int i = 0; i < 14; i++)
                numbers.Add(rnd.Next(a, c + 1));
            return numbers;
        }
    }

    // Отрисовка столбчатой диаграммы
    public class BarChartRenderer : AChartRenderer
    {
        public override void DrawChart(List<double> data, Chart chart)
        {
            Series series = new Series("Числа");
            series.ChartType = SeriesChartType.Column;

            for (int i = 0; i < data.Count; i++)
                series.Points.AddXY(i + 1, data[i]);

            chart.Series.Add(series);

            double min = data.Min();
            double max = data.Max();
            int minIndex = data.IndexOf(min);
            int maxIndex = data.IndexOf(max);

            series.Points[minIndex].Color = Color.Red;
            series.Points[maxIndex].Color = Color.Red;
            series.Points[minIndex].Label = "Min: " + min;
            series.Points[maxIndex].Label = "Max: " + max;
        }
    }

    // График функции
    public class SinFunction : AFunk
    {
        public override void Plot(Chart chart, double xMin, double xMax, double dx)
        {
            Series s = new Series("y = sin(x) + 1");
            s.ChartType = SeriesChartType.Line;

            List<double> yValues = new List<double>();

            for (double x = xMin; x <= xMax; x += dx)
            {
                double y = Math.Sin(x) + 1;
                s.Points.AddXY(x, y);
                yValues.Add(y);
            }

            chart.Series.Add(s);

            double yMin = yValues.Min();
            double yMax = yValues.Max();

            Series points = new Series("extremes");
            points.ChartType = SeriesChartType.Point;
            points.MarkerStyle = MarkerStyle.Circle;
            points.Color = Color.Red;
            points.MarkerSize = 10;

            double xAtMin = xMin + yValues.IndexOf(yMin) * dx;
            double xAtMax = xMin + yValues.IndexOf(yMax) * dx;
            points.Points.AddXY(xAtMin, yMin);
            points.Points.AddXY(xAtMax, yMax);

            chart.Series.Add(points);

            MessageBox.Show($"Минимум: y = {Math.Round(yMin, 2)}\nМаксимум: y = {Math.Round(yMax, 2)}");
        }
    }
}
