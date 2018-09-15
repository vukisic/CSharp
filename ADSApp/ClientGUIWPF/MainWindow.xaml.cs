using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientGUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ChannelFactory<IUserService> uFactory = new ChannelFactory<IUserService>("UserService");
        static ChannelFactory<IPersonService> PFactory = new ChannelFactory<IPersonService>("PersonService");

        static IUserService user = uFactory.CreateChannel();
        static IPersonService person = PFactory.CreateChannel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogInBTN_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Password;
            string auth = "";

            try
            {
                auth = user.LogIn(username, password);
                MessageBox.Show(auth, "LogIn");
                if (auth == "Success!")
                {
                    //Form2 f2 = new Form2(username);
                    //f2.Show();
                    //this.Hide();
                    Window1 window = new Window1(username);
                    App.Current.MainWindow = window;
                    this.Close();
                    window.Show();
                }
            }
            catch (FaultException<Common.DataException> ex)
            {
                MessageBox.Show(ex.Detail.Reason, "LogIn");
            }
        }
    }
}
