using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Player_Project
{
    public partial class Form1 : Form
    {
        private MP3Player player = new MP3Player();
        private string file_name = "";
        private int length = 0;
        string[] filename;
        string[] filepaths;
        bool playing = false;
        int curr = 0;
        int total =0;
        public Form1()
        {
            InitializeComponent();
            player.Volume(0);
            timer1.Start();
        }

      
        public string GetTimeMinutsAndSeconds(int miliseconds)
        {
            int second = miliseconds / 1000;
            int minut = second / 60;
            return String.Format("{0:00}", (float)minut) + ":" + String.Format("{0:00}", (float)(second % 60));
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                try
                {
                    open.Filter = "MP3 Files|*.mp3";
                    open.Multiselect = true;
                    if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        playing = false;
                        total = open.FileNames.Count();
                        filepaths = open.FileNames;
                        filename = open.SafeFileNames;
                        player.Open(open.FileNames[curr]);
                        player.Volume(0);
                        VolumeSlider.Value = 0;
                        length = player.GetLength();
                        SeekSlider.Value = 0;
                    }
                }
                catch { }
                
            }

        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (curr - 1 < 0)
                    curr = total - 1;
                else
                    --curr;

                StopBtn.PerformClick();
                player.Close();
                player.Open(filepaths[curr]);
                length = player.GetLength();
                SeekSlider.Value = 0;
                PlayBtn.PerformClick();
                player.Play();
            }
            catch { }
           
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!playing)
                {
                    PlayBtn.Image = System.Drawing.Image.FromFile(@"C:\Users\Vuk\source\repos\WinForms\MP3Player_Project\icons\icons8-circled-play-32.png");
                    player.Play();
                    playing = true;
                    NameLabel.Text = filename[curr];
                }
                else
                {
                    PlayBtn.Image = System.Drawing.Image.FromFile(@"C:\Users\Vuk\source\repos\WinForms\MP3Player_Project\icons\icons8-pause-button-32.png");
                    playing = false;
                    NameLabel.Text = "Paused";
                    player.Pause();
                }
            }
            catch { }
           
           
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (curr + 1 >= total)
                    curr = 0;
                else
                    ++curr;

                StopBtn.PerformClick();
                player.Close();
                player.Open(filepaths[curr]);
                length = player.GetLength();
                SeekSlider.Value = 0;
                PlayBtn.PerformClick();
                player.Play();
            }
            catch { }
            

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                playing = false;
                player.Stop();
            }
            catch { }
           
        }

        private void VolumeSlider_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                player.Volume(VolumeSlider.Value);
                if(VolumeSlider.Value==0)
                {
                    VolumeBtn.Image = System.Drawing.Image.FromFile(@"C:\Users\Vuk\source\repos\WinForms\MP3Player_Project\icons\icons8-mute-32.png");
                }
                else
                {
                    VolumeBtn.Image = System.Drawing.Image.FromFile(@"C:\Users\Vuk\source\repos\WinForms\MP3Player_Project\icons\icons8-audio-32.png");
                }
            }
            catch { }
            
        }

        private void SeekSlider_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (playing)
                {
                    FullLabel.Text = GetTimeMinutsAndSeconds(length);
                    CurrLabel.Text = GetTimeMinutsAndSeconds(player.GetPosition());
                    ProgressBar.Value = ((player.GetPosition() / 1000) * 100) / (length / 1000);
                    SeekSlider.Value = ((player.GetPosition() / 1000) * 100) / (length / 1000);

                }
                else
                {
                    FullLabel.Text = GetTimeMinutsAndSeconds(0);
                    CurrLabel.Text = GetTimeMinutsAndSeconds(0);
                }
            }
            catch { }
           
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeekSlider_Scroll(object sender, EventArgs e)
        {
            try
            {
                player.PlayAtPosition((SeekSlider.Value * length) / 100);
            }
            catch { }
           
        }
    }
}
