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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SunsetTextBox.Text = "";
            SunriseTextBox.Text = "";

            SunModel result=new SunModel();
            try
            {
                result = await SunProcessor.LoadSunTime();

            }
            catch (Exception)
            {

                MessageBox.Show("Error!", "SunProcessor");
            }

            SunriseTextBox.Text = result.Sunrise.ToLocalTime().ToShortTimeString();
            SunsetTextBox.Text = result.Sunset.ToLocalTime().ToShortTimeString();


        }
    }
}
