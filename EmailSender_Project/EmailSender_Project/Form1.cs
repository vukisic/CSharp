using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSender_Project
{
    public partial class Form1 : Form
    {
        public static string Email="";
        public static string Pass="";

        public Form1()
        {
            InitializeComponent();
            EmailTextBox.Select();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            Email = EmailTextBox.Text;
            Pass = PasswordTextBox.Text;
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            EmailTextBox.ForeColor = Color.Black;
            EmailTextBox.Text = "";
        }

    }
}
