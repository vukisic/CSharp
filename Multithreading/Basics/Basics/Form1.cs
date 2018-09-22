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

namespace Basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            //TimeButton.Enabled = false;
            //PrintButton.Enabled = false;

            Thread newThread = new Thread(ConsumeTime);
            newThread.Start();

            //TimeButton.Enabled = true;
            //PrintButton.Enabled = true;
        }

        private void ConsumeTime()
        {
            Thread.Sleep(5000);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            for(int i=0;i<30;++i)
            {
                listBox.Items.Add(i+1);
            }
        }
    }
}
