using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountWords()
        {
            string path = "../../../data.txt";
            string text = File.ReadAllText(path);
            string[] array = text.Split(' ');
            Thread.Sleep(10000);
            return array.Length;
        }

        //private async void button1_Click(object sender, EventArgs e)
        private void button1_Click(object sender, EventArgs e)
        {
            //Task<int> task = new Task<int>(CountWords);
            //task.Start();
            
            int count = 0;
            Thread thread = new Thread(() => 
            {
                count = CountWords();
                Action action=() => label1.Text = count.ToString();
                this.BeginInvoke(action);
            });
            thread.Start();
            label1.Text = "In Progress....";
            //int count = await task;
           
        }
    }
}
