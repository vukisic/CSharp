using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace Zipping_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                string[] arr = open.FileName.Split('.');
                ZipFile zip = new ZipFile(arr[0] + ".zip");
                zip.AddFile(open.FileName,"");
                zip.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog()==DialogResult.OK)
            {
                ZipFile zip = new ZipFile(folder.SelectedPath + ".zip");
                zip.AddDirectory(folder.SelectedPath,"");
                zip.Save();
            }
        }
    }
}
