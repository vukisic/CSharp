using DemoApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLib
{
    public partial class Form1 : Form
    {
        int maxNumber = 0;
        int currentNumber = 0;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            NextButton.Enabled = false;
        }

        private async Task LoadImage(int imageNumber=0)
        {
            ComicModel comic=new ComicModel();
            try
            {
                comic = await ComicProcessor.LoadComic(imageNumber);
            }
            catch (Exception)
            {

                MessageBox.Show("Error!","ComicProcessor");
            }
            
            if(imageNumber==0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute);
            pictureBox1.ImageLocation=uriSource.AbsoluteUri;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadImage();
        }

        private async void PreviousButton_Click(object sender, EventArgs e)
        {
           
            if(currentNumber > 1)
            {
                currentNumber -= 1;
                NextButton.Enabled = true;
                await LoadImage(currentNumber);
            }

            if (currentNumber == 1)
                PreviousButton.Enabled = false;
        }

        private async void NextButton_Click(object sender, EventArgs e)
        {
           
            if(currentNumber < maxNumber)
            {
                currentNumber += 1;
                PreviousButton.Enabled = true;
                await LoadImage(currentNumber);
            }

            if (currentNumber == maxNumber)
                NextButton.Enabled = false;

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.ShowDialog(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
