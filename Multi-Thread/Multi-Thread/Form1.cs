using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multi_Thread
{
    public partial class Form1 : Form
    {
        
        public void Circles()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                // Generate random RGB values
                int r = rnd.Next(256);
                int g = rnd.Next(256);
                int b = rnd.Next(256);
                // Create random color
                Color randomColor = Color.FromArgb(r, g, b);
                Pen randomPen = new Pen(randomColor, 4);
                // Draw circle with random color
                this.CreateGraphics().DrawEllipse(
                    randomPen,
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height),
                        20,
                        20
                    )
                );
                Thread.Sleep(100);
            }
            MessageBox.Show("Circle is compleated");
        }
        public void Rectangle()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                // Generate random RGB values
                int r = rnd.Next(256);
                int g = rnd.Next(256);
                int b = rnd.Next(256);
                // Create random color
                Color randomColor = Color.FromArgb(r, g, b);
                Pen randomPen = new Pen(randomColor, 4);
                // Draw rectangle with random color
                this.CreateGraphics().DrawRectangle(
                    randomPen,
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height),
                        20,
                        20
                    )
                );
                Thread.Sleep(100);
            }
            MessageBox.Show("Rectangle is compleated");
        }
        public void Triangle()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                // Generate random RGB values
                int r = rnd.Next(256);
                int g = rnd.Next(256);
                int b = rnd.Next(256);
                // Create random color
                Color randomColor = Color.FromArgb(r, g, b);
                Pen randomPen = new Pen(randomColor, 4);
                // Draw triangle with random color
                Point[] points = new Point[]
                {
                    new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height)),
                    new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height)),
                    new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height))
                };
                this.CreateGraphics().DrawPolygon(randomPen, points);
                Thread.Sleep(100);
            }
            MessageBox.Show("Triangle is compleated");
        }
        public void Clear()
        {
            this.CreateGraphics().Clear(Color.White);
            Thread.Sleep(100);
        }
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd;
        Thread th;
        Thread th1;
        Thread th2;
        Thread th3;
        private void button2_Click(object sender, EventArgs e)
        {
            th2 = new Thread(Rectangle);
            th2.Start();
        }
        public void clear()
        {
            this.CreateGraphics().Clear(Color.White);
            Thread.Sleep(100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th2 = new Thread(Clear);
            th2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th3 = new Thread(Rectangle);
            th3.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(Triangle);
            th.Start();
        }
    }
}
