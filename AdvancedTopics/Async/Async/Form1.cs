using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var task=GetHtmlFromUrlAsync("https://www.blic.rs");
            /*
             
                Work that is independant of Ascync operation    
            
            */

            var result = await task;
            textBox1.Text = result;
        }

        //Async
        public async Task DownloadHtmlAsync(string url)
        {
            // await -> markap for compiler that method is Async
            WebClient client = new WebClient();
            var html = await client.DownloadStringTaskAsync(url);

            using (var writer = new StreamWriter(@"../../../file.html"))
            {
                await writer.WriteAsync(html);
            }
        }

        //NonAsync
        public void DownloadHtml(string url)
        {
            WebClient client = new WebClient();
            var html = client.DownloadString(url);

            using (var writer = new StreamWriter(@"../../../file.html"))
            {
                writer.Write(html);
            }
        }

        public string GetHtmlFromUrl(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlFromUrlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
