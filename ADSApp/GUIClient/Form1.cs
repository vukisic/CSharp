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
using DataException = Common.DataException;

namespace GUIClient
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
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;
            string auth = "";

            try
            {
                auth = user.LogIn(username, password);
                MessageBox.Show(auth);
            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }

        }
    }
}
