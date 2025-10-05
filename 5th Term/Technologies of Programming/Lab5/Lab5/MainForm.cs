using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class MainForm : Form
    {
        private DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
        private Queue<string> queue = new Queue<string>();

        private int selectedIndexDLL = -1;
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = random.Next(100).ToString();
            linkedList.AddLast(name);
            queue.Enqueue(name);
            if (selectedIndexDLL == -1) selectedIndexDLL = 0;
            Invalidate();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (linkedList.Count > 0)
            {
                linkedList.RemoveAt(selectedIndexDLL);
                queue.Dequeue();
                if (selectedIndexDLL >= linkedList.Count)
                    selectedIndexDLL = linkedList.Count - 1;
                Invalidate();
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (selectedIndexDLL > 0) selectedIndexDLL--;
            Invalidate();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (selectedIndexDLL < linkedList.Count - 1) selectedIndexDLL++;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int startY = 100;


            DrawLinkedList(g, startY);
            DrawQueue(g, startY + 200);
        }

        private void DrawLinkedList(Graphics g, int y)
        {
            int x = 50;
            int index = 0;

            foreach (var elem in linkedList)
            {
                Rectangle rect = new Rectangle(x, y, 40, 40);
                Brush brush = (index == selectedIndexDLL) ? Brushes.Orange : Brushes.LightBlue;
                g.FillEllipse(brush, rect);
                g.DrawEllipse(Pens.Black, rect);
                g.DrawString(elem, Font, Brushes.Black, x + 12, y + 12);
                x += 60;
                index++;

                if (x + 50 >= ClientSize.Width) 
                {
                    x = 50;
                    y += 60;
                }
            }
        }

        private void DrawQueue(Graphics g, int y)
        {
            int x = 50;
            int index = 0;

            foreach (var elem in queue)
            {
                Rectangle rect = new Rectangle(x, y, 40, 40);
                Brush brush = (index == 0) ? Brushes.Red : Brushes.LightGreen;
                g.FillRectangle(brush, rect);
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(elem, Font, Brushes.Black, x + 12, y + 12);
                x += 60;
                index++;

                if (x + 50 >= ClientSize.Width) 
                {
                    x = 50;
                    y += 60;
                }
            }
        }
    }

    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Value;
            public Node Next;
            public Node Prev;
            public Node(T value) { Value = value; }
        }

        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void AddLast(T value)
        {
            Node node = new Node(value);
            if (head == null)
                head = tail = node;
            else
            {
                tail.Next = node;
                node.Prev = tail;
                tail = node;
            }
            Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count) return;
            Node current = head;
            for (int i = 0; i < index; i++)
                current = current.Next;

            if (current.Prev != null)
                current.Prev.Next = current.Next;
            else
                head = current.Next;

            if (current.Next != null)
                current.Next.Prev = current.Prev;
            else
                tail = current.Prev;

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
