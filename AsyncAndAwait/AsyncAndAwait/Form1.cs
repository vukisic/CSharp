using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {

        CancellationTokenSource token;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            var watch = Stopwatch.StartNew();

            RunDownloadParallelSync();

            watch.Stop();
            var elapsedMS = watch.ElapsedMilliseconds;
            TextBox.Text += $"Elapsed milliseconds: {elapsedMS} ms";
        }

        private async void ButtonAsync_Click(object sender, EventArgs e)
        {
            token = new CancellationTokenSource();
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;

            TextBox.Text = "";
            var watch = Stopwatch.StartNew();

            try
            {
                var result = await RunDownloadAsync(progress, token.Token);
                ReportList(result);
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show("Canceled!", "App");
                TextBox.Text += "Operation cancelled!" + Environment.NewLine;
                
            }
            

            watch.Stop();
            var elapsedMS = watch.ElapsedMilliseconds;
            MessageBox.Show("Complited!","App");
            TextBox.Text += $"Elapsed milliseconds: {elapsedMS} ms";
        }

        private void ReportProgress(object sender, ProgressReportModel e)
        {
            ProgressBar.Value = e.Progress;
            TextBox.Text = "";
            ReportList(e.WebSites);
        }

        private async void ButtonParallel_Click(object sender, EventArgs e)
        {
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;
            TextBox.Text = "";
            var watch = Stopwatch.StartNew();
           

            var result=await DownloadParralelAsync(progress);
            ReportList(result);

            watch.Stop();
            var elapsedMS = watch.ElapsedMilliseconds;
            TextBox.Text += $"Elapsed milliseconds: {elapsedMS} ms";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            token.Cancel();
        }

        #region Helper Methods
        private List<string> PrepData()
        {
            List<string> output = new List<string>
            {
                "https://www.google.com",
                "https://www.yahoo.com",
                "https://www.gmail.com",
                "https://www.stackoverflow.com",
                "https://www.freecodecamp.com",
                "https://www.bbc.com",

            };
            return output;
        }

        private void RunDownloadSync()
        {
            List<string> list = PrepData();

            foreach (var url in list)
            {
                WebsiteDataModel result =DownloadSite(url);
                ReportWebsiteInfo(result);
            }
        }

        private void RunDownloadParallelSync()
        {
            List<string> list = PrepData();

            Parallel.ForEach<string>(list, (x) =>{
                WebsiteDataModel result = DownloadSite(x);
                ReportWebsiteInfo(result);
            });
        }

        private async Task<List<WebsiteDataModel>> RunDownloadAsync(IProgress<ProgressReportModel> progress, CancellationToken cancellationToken)
        {
            List<string> list = PrepData();
            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();

            foreach (var url in list)
            {
                WebsiteDataModel result = await DownloadSiteAsync(url);
                output.Add(result);

                cancellationToken.ThrowIfCancellationRequested();

                report.WebSites = output;
                report.Progress = (output.Count * 100) / list.Count;
                progress.Report(report);
            }

            return output;
        }

        private async Task RunDownloadParallelAsync()
        {
            List<string> list = PrepData();
            List<Task<WebsiteDataModel>> taskList = new List<Task<WebsiteDataModel>>();
            

            foreach (var url in list)
            {
                taskList.Add(Task.Run(() => DownloadSite(url)));
            }

            var results = await Task.WhenAll(taskList);

            foreach (var item in results)
            {
                ReportWebsiteInfo(item);
            }


        }

        private async Task<List<WebsiteDataModel>> DownloadParralelAsync(IProgress<ProgressReportModel> progress)
        {
            List<string> list = PrepData();
            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();

            await Task.Run(() => {
                Parallel.ForEach<string>(list, (x) =>
                 {
                     WebsiteDataModel result = DownloadSite(x);
                     output.Add(result);
                     report.WebSites = output;
                     report.Progress = (output.Count * 100) / list.Count;
                     progress.Report(report);
                 });

            });
            return output;
        }

        private WebsiteDataModel DownloadSite(string url)
        {
            WebsiteDataModel webSite = new WebsiteDataModel();
            WebClient client = new WebClient();

            webSite.Url = url;
            webSite.Content = client.DownloadString(url);

            return webSite;
        }

        private async Task<WebsiteDataModel> DownloadSiteAsync(string url)
        {
            WebsiteDataModel webSite = new WebsiteDataModel();
            WebClient client = new WebClient();

            webSite.Url = url;
            webSite.Content = await client.DownloadStringTaskAsync(url);

            return webSite;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            TextBox.Text += $"{data.Url} downloaded: {data.Content.Length} characters. {Environment.NewLine}";
        }

        private void ReportList(List<WebsiteDataModel> data)
        {
            foreach (var item in data)
            {
                TextBox.Text += $"{item.Url} downloaded: {item.Content.Length} characters. {Environment.NewLine}";
            }
            
        }
        #endregion


    }
}
