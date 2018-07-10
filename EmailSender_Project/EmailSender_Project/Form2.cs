using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailSender_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            EmailTextBox.ForeColor = Color.Black;
            EmailTextBox.Text = "";
        }

        private void SubjectTextBox_Click(object sender, EventArgs e)
        {
            SubjectTextBox.ForeColor = Color.Black;
            SubjectTextBox.Text = "";
        }

        private void TextBoxText_Click(object sender, EventArgs e)
        {
            TextBoxText.ForeColor = Color.Black;
            TextBoxText.Text = "";
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(!EmailTextBox.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Error!\nMake sure that you entered @gmail.com address" +
                    " !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SendBtn.Enabled = false;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Form1.Email);
                mail.Subject = SubjectTextBox.Text;
                mail.Body = TextBoxText.Text;
                mail.To.Add(new MailAddress(EmailTextBox.Text));

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(Form1.Email, Form1.Pass);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch
            {
                SendBtn.Enabled = false;
                MessageBox.Show("Error!\nMake sure that you entered right info and check your Internet Connection\n" +
                    " !","Error!" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SendBtn.Enabled = true;
            }
           
        }
    }
}
