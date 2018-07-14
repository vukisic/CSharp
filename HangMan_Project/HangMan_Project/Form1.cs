using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan_Project
{
    public partial class Form1 : Form
    {

        List<Label> labels = new List<Label>();
        string main_word = "";
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public enum BodyParts
        {
            Head,
            LeftEye,
            RightEye,
            Mouth,
            Body,
            RightArm,
            LeftArm,
            RightLeg,
            LeftLeg
        }

        private void DrawHangPost()
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Red, 10);
            g.DrawLine(p,new Point(220,420),new Point(220,10));
            g.DrawLine(p,new Point(225,5),new Point(110,5));
            g.DrawLine(p,new Point(110,0),new Point(110,60));
            RandomWord();
            MakeLabels();

        }

        private void DrawBodyParts(BodyParts b)
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Red,3);
            SolidBrush br = new SolidBrush(Color.Black);
            switch (b)
            {
                case BodyParts.Head:
                    g.DrawEllipse(p, 70, 60,80, 80);
                break;
                case BodyParts.LeftEye:
                    g.FillEllipse(br, 85, 75, 10, 10);
                break;
                case BodyParts.RightEye:
                    g.FillEllipse(br, 120, 75, 10, 10);
                break;
                case BodyParts.Mouth:
                    g.DrawArc(p, 85,75,50,50,45,90);
                break;
                case BodyParts.Body:
                    g.DrawLine(p, 110,140,110,281);
                break;
                case BodyParts.LeftArm:
                    g.DrawLine(p, 110, 180, 50, 150);
                break;
                case BodyParts.RightArm:
                    g.DrawLine(p, 110, 180, 170, 150);
                break;
                case BodyParts.LeftLeg:
                    g.DrawLine(p, 110, 280, 50,350);
                break;
                case BodyParts.RightLeg:
                    g.DrawLine(p, 110, 280, 170, 350);
                break;
            }

        }

        private string RandomWord()
        {
            string word = "";
            string[] words;
            using (TextReader reader = File.OpenText("../../../words.txt"))
            {
                string temp = reader.ReadToEnd();
                words = temp.Split('\n');
            }
            Random rand = new Random();
            int index = rand.Next(0, words.Length);
            word = words[index];
            LengthLabel.Text = "Word Length :"+" " + (word.Length-1).ToString();
            main_word = word;
            return word;
        }

        private void MakeLabels()
        {
            string word = main_word;
            char[] chars = word.ToCharArray();
            int space = 400 / (chars.Length - 1);
            for(int i=0;i<chars.Length-1;++i)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * space)+10, 80);
                labels[i].Text = "__";
                labels[i].Parent = Wordgb;
                labels[i].Size = new Size(30, 30);
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
        }

        private void SubmitLetterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = Lettertb.Text[0];
                if (!char.IsLetter(letter))
                {
                    MessageBox.Show("You can only submit letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (main_word.Contains(letter))
                    {
                        char[] letters = main_word.ToLower().ToCharArray();
                        for (int i = 0; i < letters.Length - 1; ++i)
                        {
                            if (letters[i] == letter)
                            {
                                labels[i].Text = letter.ToString();
                            }
                        }
                        foreach (var item in labels)
                        {
                            if (item.Text == "__")
                                return;
                        }
                        MessageBox.Show("You Won!", "Won", MessageBoxButtons.OK);
                        ResetGame();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Letter!", "Letter " + letter.ToString(), MessageBoxButtons.OK);
                        MissedLabel.Text += " " + letter.ToString() + ",";
                        DrawBodyParts((BodyParts)counter);
                        ++counter;
                        if (counter == 9)
                        {
                            MessageBox.Show("Lose!\nWord:" + main_word, "End Game!", MessageBoxButtons.OK);
                            ResetGame();
                        }
                    }
                }
            }
            catch { }
            
        }

        private void ResetGame()
        {
            Graphics g = DrawPanel.CreateGraphics();
            g.Clear(DrawPanel.BackColor);
            MissedLabel.Text = "Missed :";
            counter = 0;
            Lettertb.Text = "";
            Wordtb.Text = "";
            foreach (var item in labels)
            {
                item.Text = "";
            }
            labels.Clear();
            DrawHangPost();
        }

        private void Lettertb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                SubmitLetterbtn.PerformClick();
            }
        }

        private void SubmitWordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Wordtb.Text+"\r" == main_word)
                {
                    MessageBox.Show("You Won!", "Won!", MessageBoxButtons.OK);
                    ResetGame();
                }
                else
                {
                    MessageBox.Show("Wrong Word:"+Wordtb.Text+"!", "Wrong Word", MessageBoxButtons.OK);
                    DrawBodyParts((BodyParts)counter);
                    ++counter;
                    if (counter == 9)
                    {
                        MessageBox.Show("Lose!\nWord:" + main_word, "End Game!", MessageBoxButtons.OK);
                        ResetGame();
                    }
                }
            }
            catch { }
           
        }

        private void Wordtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SubmitWordbtn.PerformClick();
            }
        }
    }
}
