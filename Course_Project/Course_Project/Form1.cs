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
using System.Xml;

namespace Course_Project
{
    public partial class Form1 : Form
    {
        int counter = 0;
        string file_name;
        bool file_opened = false;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
            StatusPanel.Hide();
           
        }

        private void GridBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            StatusPanel.Hide();
        }

        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            StatusPanel.Show();
            UpdateStatistic();
        }

        private int GetSumOfECTS()
        {
            int sumects = 0;
            for(int i=0;i<counter;++i)
            {
                if((string)(dataGridView1.Rows[i].Cells[3].Value) == "True")
                    sumects += Int32.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            return sumects;
        }

        private int GetSumOfGrades()
        {
            int grades = 0;
            for (int i = 0; i < counter; ++i)
            {
                if((string)(dataGridView1.Rows[i].Cells[3].Value) == "True")
                    grades += Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            return grades;
        }

        private int GetNumOfPassed()
        {
            int passed = 0;
            for (int i = 0; i < counter; ++i)
            {
                if ((string)(dataGridView1.Rows[i].Cells[3].Value) == "True")
                    passed += 1;
            }
            return passed;
        }

        private int GetNumOfGrades(int grade)
        {
            int grades = 0;
            for (int i = 0; i < counter; ++i)
            {
                if (Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) == grade &&
                    (string)(dataGridView1.Rows[i].Cells[3].Value)=="True")
                    grades += 1;
            }
            return grades;
        }

        private void UpdateStatistic()
        {
            FinalECTS.Text = GetSumOfECTS().ToString();
            double sumgrades = (double)GetSumOfGrades();
            FinalGrade.Text = (Math.Round(sumgrades / GetNumOfPassed(), 2)).ToString();

            double c10 = GetNumOfGrades(10);
            double c9 = GetNumOfGrades(9);
            double c8 = GetNumOfGrades(8);
            double c7 = GetNumOfGrades(7);
            double c6 = GetNumOfGrades(6);
            double cx = counter-(c10+c9+c8+c7+c6);

            pb10.Value=(int)((c10/counter)*100);
            pb9.Value=(int)((c9/counter)*100);
            pb8.Value=(int)((c8/counter)*100);
            pb7.Value=(int)((c7/counter)*100);
            pb6.Value=(int)((c6/counter)*100);
            pbX.Value=(int)((cx/counter)*100);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CourseTextBox.Text!="" && ECTSTextBox.Text!="" && GradeTextBox1.Text!="")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[counter].Cells[0].Value = CourseTextBox.Text;

                    int ects = Int32.Parse(ECTSTextBox.Text);
                    if (ects <= 0 || ects >= 10)
                        ects = 0;
                    dataGridView1.Rows[counter].Cells[1].Value = ects;

                    int grade = Int32.Parse(GradeTextBox1.Text);
                    if (grade <= 5 || grade >= 11)
                        grade = 0;
                    dataGridView1.Rows[counter].Cells[2].Value = grade;
                    dataGridView1.Rows[counter].Cells[3].Value = PassedCheckBox.Checked.ToString();
                    ++counter;
                }
                CourseTextBox.Text = ECTSTextBox.Text = GradeTextBox1.Text = "";
                UpdateStatistic();
            }
            catch
            {

            }
        }

        private void SaveToXml(string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Courses");

                for (int i = 0; i < counter; ++i)
                {
                    writer.WriteStartElement("Course");
                    string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string ects = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string grade = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string passed = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    writer.WriteElementString("Name", name);
                    writer.WriteElementString("ECTS", ects);
                    writer.WriteElementString("Grade", grade);
                    writer.WriteElementString("Passed", passed);
                    writer.WriteEndElement();
                }


                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(file_opened)
            {
                SaveToXml(file_name);
            }
            else
            {
                SaveAs.PerformClick();
            }
            
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            counter = 0;
            file_opened = true;
            string course = "";
            int ects = 0;
            int grade = 0;
            bool passed;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML|*.xml";
            if(open.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                file_name = open.FileName;
                using (XmlReader reader= XmlReader.Create(open.FileName))
                {
                    while(reader.Read())
                    {
                        if(reader.IsStartElement() && reader.Name=="Course")
                        {
                            while (reader.Name != "Name")
                                reader.Read();
                            reader.Read();
                            course = reader.Value;

                            while (reader.Name != "ECTS")
                                reader.Read();
                            reader.Read();
                            ects = Int32.Parse(reader.Value);

                            while (reader.Name != "Grade")
                                reader.Read();
                            reader.Read();
                            grade = Int32.Parse(reader.Value);

                            while (reader.Name != "Passed")
                                reader.Read();
                            reader.Read();
                            passed= reader.Value=="True"?true:false;

                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[counter].Cells[0].Value = course;
                            dataGridView1.Rows[counter].Cells[1].Value = ects;
                            dataGridView1.Rows[counter].Cells[2].Value = grade;
                            dataGridView1.Rows[counter].Cells[3].Value = passed.ToString() ;
                            ++counter;

                        }
                    }
                }
            }
            UpdateStatistic();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML|*.xml";
            if(save.ShowDialog()==DialogResult.OK)
            {
                SaveToXml(save.FileName);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStatistic();
        }
    }
}
