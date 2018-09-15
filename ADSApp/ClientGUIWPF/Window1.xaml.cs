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
using System.Windows.Shapes;

namespace ClientGUIWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static string Username;
        static ChannelFactory<IUserService> uFactory = new ChannelFactory<IUserService>("UserService");
        static ChannelFactory<IPersonService> PFactory = new ChannelFactory<IPersonService>("PersonService");

        static IUserService user = uFactory.CreateChannel();
        static IPersonService person = PFactory.CreateChannel();
        public Window1(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void RefreshTable()
        {
            try
            {
                List<Person> list = new List<Person>();
                list = person.PersonsToList(Username);
                PersonsListView.ItemsSource = list;
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason, "App");
            }

        }

        private void RefreshBNT_Click(object sender, RoutedEventArgs e)
        {
            RefreshTable();

        }

        private void JSONBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                person.PrintPersonsInJSON(Username, JSONTB.Text);
                MessageBox.Show("Printed in file: " + JSONTB.Text, "App");
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason, "App");
            }
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Person per = new Person(FirstNameTB.Text, LastNameTB.Text, Int32.Parse(AddIdTB.Text));
                person.AddPerson(Username, per);
                MessageBox.Show("Added Person with ID: " + AddIdTB.Text, "App");
                RefreshTable();
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason, "App");
            }
        }

        private void RemoveBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                person.RemovePerson(Username, Int32.Parse(RemoveIdTB.Text));
                MessageBox.Show("Removed Person with ID: " + RemoveIdTB.Text, "App");
                RefreshTable();
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason, "App");
            }
        }
    }
}
