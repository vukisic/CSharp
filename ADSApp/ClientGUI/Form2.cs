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
    public partial class Form2 : Form
    {
        static string Username;
        static ChannelFactory<IUserService> uFactory = new ChannelFactory<IUserService>("UserService");
        static ChannelFactory<IPersonService> PFactory = new ChannelFactory<IPersonService>("PersonService");

        static IUserService user = uFactory.CreateChannel();
        static IPersonService person = PFactory.CreateChannel();
        public Form2(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            listViewAll.Items.Clear();
            try
            {
                List<Person> list = new List<Person>();
                list = person.PersonsToList(Username);
                foreach (var item in list)
                {
                    listViewAll.Items.Add(new ListViewItem(new string[] { item.Firstname,item.Lastname, item.Id.ToString()}));
                }
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason,"App");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listViewAll.View = View.Details;
            listViewAll.Columns.Add("FirstName");
            listViewAll.Columns.Add("LastName");
            listViewAll.Columns.Add("Id");
            listViewAll.GridLines = true;
            listViewAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void JSONBtn_Click(object sender, EventArgs e)
        {
            try
            {
                person.PrintPersonsInJSON(Username, FileNameTb.Text);
                MessageBox.Show("Printed in file: "+FileNameTb.Text, "App");
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason,"App");
            }

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                person.RemovePerson(Username,Int32.Parse(IDRemoveTb.Text));
                MessageBox.Show("Removed Person with ID: " + IDRemoveTb.Text, "App");
            }
            catch (FaultException<Common.DataException> ex)
            {
     
                MessageBox.Show(ex.Detail.Reason, "App");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Person per = new Person(FirstNameTb.Text, LastNameTb.Text, Int32.Parse(IDAddTb.Text));
                person.AddPerson(Username, per);
                MessageBox.Show("Added Person with ID: " + IDAddTb.Text, "App");
            }
            catch (FaultException<Common.DataException> ex)
            {

                MessageBox.Show(ex.Detail.Reason, "App");
            }
        }
    }
}
