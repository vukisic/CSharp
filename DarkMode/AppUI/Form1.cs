using DataBaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class Form1 : Form
    {
        List<SubjectModel> list = new List<SubjectModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TotalScore(int passed)
        {
            double sum = 0;
            foreach (var item in list)
            {
                if (item.Grade > 5)
                    sum += item.Grade;
            }

            double average = sum / passed;
            TotalLable.Text = (Math.Round(average,2)).ToString();
        }

        private void PassedNotPassedCount()
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.Grade > 5)
                    ++count;
            }

            PassedLable.Text = count.ToString();
            NPassedLable.Text = (list.Count - count).ToString();
            TotalScore(count);
        }

        private void CreateTable()
        {
            ListView.View = View.Details;
            ListView.Columns.Add("Subject");
            ListView.Columns.Add("Grade");
            ListView.Columns[0].Width = 300;
            ListView.Columns[1].Width = 100;
        }

        private void PopulateList()
        {
            ListView.Items.Clear();
            list = DataHelper.LoadData();
            foreach (var item in list)
            {
                ListView.Items.Add(new ListViewItem(new[] { item.SubjectName, item.Grade.ToString()}));
            }
            PassedNotPassedCount();
        }

        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTable();
            PopulateList();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PopulateList();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SubjectModel temp = new SubjectModel
            {
                Grade = Convert.ToInt32(GradeNumBox.Value),
                SubjectName = SubjectTextBox.Text
            };

            DataHelper.SaveData(temp);
            PopulateList();

            GradeNumBox.Value = 5;
            SubjectTextBox.Text = "";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataHelper.DeleteData(SubRemoveTextBox.Text);
                PopulateList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!" + Environment.NewLine + ex.Message, "App");
            }

            SubRemoveTextBox.Text = "";
        }
    }

   
}
