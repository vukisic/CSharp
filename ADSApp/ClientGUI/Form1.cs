using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGUI
{
    public partial class Form1 : Form
    {
        static ChannelFactory<IUserService> uFactory = new ChannelFactory<IUserService>("UserService");
        static ChannelFactory<IPersonService> PFactory = new ChannelFactory<IPersonService>("PersonService");

        static IUserService user = uFactory.CreateChannel();
        static IPersonService person = PFactory.CreateChannel();
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;
            string auth = "";

            try
            {
                auth = user.LogIn(username, password);
                MessageBox.Show(auth, "LogIn");
                if(auth=="Success!")
                {
                    Form2 f2 = new Form2(username);
                    f2.Show();
                    this.Hide();

                }
            }
            catch (FaultException<Common.DataException> ex)
            {
                MessageBox.Show(ex.Detail.Reason, "LogIn");
            }
        }
    }
}
