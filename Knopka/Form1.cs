using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knopka
{
    public partial class Form1 : Form
    {

        Pen pen;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, 5);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Point[] points = new Point[]
            {
                new Point(150, 30),new Point(170, 100),new Point(240, 100),new Point(180, 140),new Point(200, 210),
                new Point(150, 170),new Point(100, 210),new Point(120, 140),new Point(60, 100),new Point(130, 100),new Point(150, 30)

            };
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddLines(points);
            graphics.FillPath(Brushes.Black, graphicsPath);
            graphics.DrawLines(pen, points);
            Region reg = new Region(graphicsPath);
            button1.Region = reg;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, 7);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 5);
        }
    }
}
