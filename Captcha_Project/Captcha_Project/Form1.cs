using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Captcha_Project
{
    public partial class Form1 : Form
    {
        List<string> strings = new List<string>();
        string path = "";
        string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private Image[] GenerateCaptchas(int amount)
        {
            Image[] arr = new Image[amount];
            Random rand = new Random();
            for (int k=0;k<amount;k++)
            {
                Bitmap bitmap = new Bitmap(CaptchaPanel.Width, CaptchaPanel.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.Clear(CaptchaPanel.BackColor);
                SolidBrush brush = new SolidBrush(Color.FromArgb(0xFF, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                Pen pen = new Pen(Color.FromArgb(0xFF, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                char[] chars = "qwertyuiopasdfghjklzxcvbnm1234567890".ToCharArray();
                string random_string = "";
                FontFamily ff = new FontFamily("Arial");
                Font f = new Font(ff, 36);
                for (int i = 0; i < 6; ++i)
                {
                    int random_index = rand.Next(0, 35);
                    random_string += chars[random_index].ToString();
                }
                byte[] buffer = new byte[random_string.Length];
                int j = 0;
                foreach (var item in random_string.ToCharArray())
                {
                    buffer[j] = (byte)item;
                    ++j;
                }
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string file_name = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-","");
                strings.Add(file_name);
                graphics.DrawString(random_string, f, brush, 30, 30);
                for (int i = 0; i < 6; ++i)
                {
                    int g = rand.Next(0, 2);
                    if (g == 0)
                    {
                        graphics.DrawRectangle(pen, rand.Next(0, 127), rand.Next(0, 65), rand.Next(0, 127), rand.Next(0, 65));
                    }
                    else
                    {
                        graphics.DrawEllipse(pen, rand.Next(0, 127), rand.Next(0, 65), rand.Next(0, 127), rand.Next(0, 65));
                    }
                    pen.Color = Color.FromArgb(0xFF, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                }
                CaptchaPanel.BackgroundImage = bitmap;
                arr[k] = bitmap;
            }
            
            return arr;
        }

        private void Generatebtn_Click(object sender, EventArgs e)
        {
            Image[] imgs=GenerateCaptchas(Convert.ToInt32(AmountNum.Value));
            int i = 0;
            foreach (var item in imgs)
            {
                item.Save(path + "\\" + strings[i]+".png");
                ++i;
            }
        }

        private void Generatebtn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                Generatebtn.PerformClick();
            }
        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog()==DialogResult.OK)
            {
                path = folder.SelectedPath;
            }
        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png";
            if(open.ShowDialog()==DialogResult.OK)
            {
                panel1.BackgroundImage = Image.FromFile(open.FileName);
                name = Path.GetFileNameWithoutExtension(open.FileName);
            }
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] buffer = new byte[Texttb.Text.Length];
            int j = 0;
            foreach (var item in Texttb.Text.ToCharArray())
            {
                buffer[j] = (byte)item;
                ++j;
            }
            string alpha = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");
            if(alpha!=name)
            {
                MessageBox.Show("You got it wrong!", "Wrong!");
            }
            else
            {
                MessageBox.Show("You got it right!", "Right!");
            }
        }
    }
}
