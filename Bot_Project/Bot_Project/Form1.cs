using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        WebBrowser wb = new WebBrowser();
        bool stop = false;

        private void button1_Click(object sender, EventArgs e)
        {
            stop = false;
            timer1.Interval = Int32.Parse(numericUpDown1.Value.ToString()) * 1000;
            timer1.Start();
        }

        private void TFunc()
        {
            if(!stop)
            {
                wb.Navigate(Linktb.Text);
                string t = wb.DocumentText;
                if (t.Contains(Stringtb.Text))
                {
                    textBox1.Text += "True" + Environment.NewLine;
                    SystemSounds.Beep.Play();
                }
                else
                {
                    textBox1.Text += "False" +DateTime.Now+ Environment.NewLine;
                }
            }
            else
            {

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TFunc();
        }
    }
}
