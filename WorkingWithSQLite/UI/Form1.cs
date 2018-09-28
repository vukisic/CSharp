using SQLite_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateList()
        {
            people = SQLiteDataAccess.LoadPeople();
            ListBox.DataSource = null;
            ListBox.DataSource = people;
            ListBox.DisplayMember = "FullName";
            numericUpDown.Maximum = people.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateList();
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();
            person.FirstName = FirstNameTextBox.Text;
            person.LastName = LastNameTextBox.Text;

            SQLiteDataAccess.SavePerson(person);
            PopulateList();

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SQLiteDataAccess.DeletePerson(Convert.ToInt32(numericUpDown.Value));
            PopulateList();
        }
    }
}
