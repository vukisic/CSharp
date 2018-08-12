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

namespace ScreenShot_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image image = Clipboard.GetImage();
            pictureBox.Image = image;
            Thread.Sleep(500);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG|*.jpeg";
            if(save.ShowDialog()==DialogResult.OK)
            {
                image.Save(save.FileName);
            }
            this.Show();
        }
    }
}
