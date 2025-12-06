using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_8
{
    public partial class Form1 : Form
    {
        private Bitmap map;
        private int cpu_cores;
        private Random rng;
        private const int PADDING = 5;
        private const int OFFSET = 30;
        private void clearCanvas()
        {
            using (var g = Graphics.FromImage(map))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Refresh();
        }
        private Point initialRandomPoint()
        {
            return new Point(rng.Next(PADDING, pictureBox1.Width - PADDING), rng.Next(PADDING,
            pictureBox1.Height - PADDING));
        }
        private Point nextRandomPoint(ref Point prev)
        {
            return new Point(
            rng.Next(Math.Max(PADDING, prev.X - OFFSET), Math.Min(prev.X + OFFSET,
            pictureBox1.Width - PADDING)),
            rng.Next(Math.Max(PADDING, prev.Y - OFFSET), Math.Min(prev.Y + OFFSET,
            pictureBox1.Height - PADDING))
            );
        }
        private Point[] randomPolygon()
        {
            var res = new Point[rng.Next(3, 8)];
            
            res[0] = initialRandomPoint();
            for (int i = 1; i < res.Length; i++)
                res[i] = nextRandomPoint(ref res[i - 1]);
            return res;
        }
        private void drawRandomPolygon(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0,
            255)), 3);
            lock (g)
            {
                g.FillPolygon(pen.Brush, randomPolygon());
            }
        }
        private void threadWorker(object obj)
        {
            var g = (Graphics)obj;
            drawRandomPolygon(g);
            Thread.Sleep(500);
        }
        private void drawPrimitives()
        {
            int polys;
            if (!int.TryParse(textBox1.Text, out polys))
            {
                polys = rng.Next(10, 20);
                textBox1.Text = polys.ToString();
            }

            var g = Graphics.FromImage(map);
            g.Clear(Color.White);
            Thread[] ts = new Thread[cpu_cores];
            while (polys > 0)
            {
                int busy_threads_count = 0;
                for (int i = 0; i < ts.Length && polys > 0; i++)
                {
                    ts[i] = new Thread(threadWorker);
                    ts[i].Start(g);
                    polys -= 1;
                    busy_threads_count += 1;
                }
                for (int i = 0; i < busy_threads_count; i++)
                    ts[i].Join();
                pictureBox1.Refresh();
            }


        }
        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = map;
            clearCanvas();
            cpu_cores = Environment.ProcessorCount;
            
            rng = new Random();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawPrimitives();
        }
    }
}
