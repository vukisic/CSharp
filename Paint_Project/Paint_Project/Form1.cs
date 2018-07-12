using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Project
{
    public partial class Form1 : Form
    {
        bool CanWork = false;
        Graphics graphics;
        int? prevX = null;
        int? prevY = null;
        Color color = Color.Black;
        bool square = false;
        bool rectangle = false;
        bool circle = false;
        int size = 50;

        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            CanWork = true;
            if(square)
            {
                try
                {
                    size = Convert.ToInt32(SSizetb.Text);
                }
                catch { size = 50; }
                SolidBrush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, e.X, e.Y, size, size);
                square = false;
                CanWork = false;
            }
            else if(circle)
            {
                try
                {
                    size = Convert.ToInt32(SSizetb.Text);
                }
                catch { size = 50; }
                SolidBrush brush = new SolidBrush(color);
                graphics.FillEllipse(brush, e.X, e.Y, size, size);
                circle = false;
                CanWork = false;
            }
            else if(rectangle)
            {
                try
                {
                    size = Convert.ToInt32(SSizetb.Text);
                }
                catch { size = 50; }
                SolidBrush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, e.X, e.Y, size*2, size);
                rectangle = false;
                CanWork = false;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            CanWork = false;
            prevX = null;
            prevY = null;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(CanWork)
            {
                /*SolidBrush brush = new SolidBrush(Color.Black);
                graphics.FillEllipse(brush, e.X, e.Y, Convert.ToInt32(Sizetb.Text), Convert.ToInt32(Sizetb.Text));*/
                Pen pen = new Pen(color, float.Parse(Sizetb.Text));
                graphics.DrawLine(pen, prevX ?? e.X, prevY ?? e.Y, e.X, e.Y);
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                Colorbtn.BackColor = cd.Color;
                color = cd.Color;
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }

        private void BackColorbtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = cd.Color;
                BackColorbtn.BackColor = cd.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            square = true;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangle = true;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circle = true;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            foreach (var item in files)
            {
                Image img = Image.FromFile(item);
                graphics.DrawImage(img, new Point(0, 0));
            }
        }
    }
}
