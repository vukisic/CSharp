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

namespace AddressBook_Project
{
    public partial class Form1 : Form
    {
        List<Person> list = new List<Person>();
        string path = "../../../";
        string file_path = "../../../AdressBookVuk/settings.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(path + "AdressBookVuk"))
                Directory.CreateDirectory(path+ "AdressBookVuk");
            if (!File.Exists(file_path))
            {
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Indent = true
                };

                using (XmlWriter wr=XmlWriter.Create(file_path,settings))
                {
                    wr.WriteStartDocument();
                    wr.WriteStartElement("People");
                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                }
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file_path);
            foreach (XmlNode item in xDoc.SelectNodes("People/Person"))
            {
                Person temp = new Person();
                temp.Name = item.SelectSingleNode("Name").InnerText;
                temp.Address = item.SelectSingleNode("Address").InnerText;
                temp.Email = item.SelectSingleNode("Email").InnerText;
                temp.Birthday = DateTime.FromFileTime(Convert.ToInt64(item.SelectSingleNode("Birthday").InnerText));
                temp.Notes = item.SelectSingleNode("Notes").InnerText;
                list.Add(temp);
                PeopleListView.Items.Add(temp.Name);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person(Nametb.Text,Addresstb.Text,Emailtb.Text,Notesttb.Text,Birthdaydp.Value);
            list.Add(p);
            PeopleListView.Items.Add(p.Name);
            Nametb.Text = "";
            Addresstb.Text = "";
            Emailtb.Text = "";
            Notesttb.Text = "";
            Birthdaydp.Text = "";
        }

        private void PeopleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Nametb.Text = list[PeopleListView.SelectedItems[0].Index].Name;
                Addresstb.Text = list[PeopleListView.SelectedItems[0].Index].Address;
                Emailtb.Text = list[PeopleListView.SelectedItems[0].Index].Email;
                Notesttb.Text = list[PeopleListView.SelectedItems[0].Index].Notes;
                Birthdaydp.Text = list[PeopleListView.SelectedItems[0].Index].Birthday.ToString();
            }
            catch { }
            
        }

        private void Remove()
        {
            try
            {
                PeopleListView.Items.Remove(PeopleListView.SelectedItems[0]);
                list.RemoveAt(PeopleListView.SelectedItems[0].Index);
            }
            catch { }
           
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            list[PeopleListView.SelectedItems[0].Index].Name = Nametb.Text;
            list[PeopleListView.SelectedItems[0].Index].Address = Addresstb.Text;
            list[PeopleListView.SelectedItems[0].Index].Email = Emailtb.Text;
            list[PeopleListView.SelectedItems[0].Index].Notes = Notesttb.Text;
            list[PeopleListView.SelectedItems[0].Index].Birthday = Birthdaydp.Value;
            PeopleListView.SelectedItems[0].Text = Nametb.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file_path);
            XmlNode node = xDoc.SelectSingleNode("People");
            node.RemoveAll();
            foreach (var item in list)
            {
                XmlNode temp = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xAddr = xDoc.CreateElement("Address");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                xName.InnerText = item.Name;
                xAddr.InnerText = item.Address;
                xEmail.InnerText = item.Email;
                xBirthday.InnerText = item.Birthday.ToFileTime().ToString();
                xNotes.InnerText = item.Notes;
                temp.AppendChild(xName);
                temp.AppendChild(xAddr);
                temp.AppendChild(xEmail);
                temp.AppendChild(xBirthday);
                temp.AppendChild(xNotes);
                xDoc.DocumentElement.AppendChild(temp);

            }
            xDoc.Save(file_path);
        }
    }
}
