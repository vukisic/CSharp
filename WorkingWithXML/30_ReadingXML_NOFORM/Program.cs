using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _30_ReadingXML_NOFORM
{
    class Program
    {
        public static XmlDocument xDoc=new XmlDocument();
        public static string path = "";
        static void Main(string[] args)
        {
            path = "../../../text.xml";
            ReadXml();
            EditXml();
            WriteNewXml();
            WriteExistingXml();
            Delete("Mike");
        }

        public static void ReadXml()
        {
            xDoc.Load(path);
            foreach (XmlNode item in xDoc.SelectNodes("People/Person"))
            {
                Console.WriteLine(item.SelectSingleNode("Name").InnerText);
            }
        }

        public static void EditXml()
        {
            foreach (XmlNode item in xDoc.SelectNodes("People/Person"))
            {
                if(item.SelectSingleNode("Name").InnerText=="Marko")
                {
                    item.SelectSingleNode("Age").InnerText = "33";
                }
            }

            xDoc.Save(path);
        }

        public static void WriteNewXml()
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            { Indent = true };

            using (XmlWriter wr = XmlWriter.Create("../../../newtext.xml",settings))
            {
                wr.WriteStartDocument();
                wr.WriteStartElement("People");
                wr.WriteStartElement("Person");
                wr.WriteElementString("Name", "Vuk");
                wr.WriteElementString("Age", "21");
                wr.WriteElementString("Email", "visicev@gmail.com");
                wr.WriteEndElement();
                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }

        public static void WriteExistingXml()
        {
            xDoc.Load("../../../newtext.xml");
            XmlNode person = xDoc.CreateElement("Person");
            XmlNode name = xDoc.CreateElement("Name");
            name.InnerText = "Mike";
            person.AppendChild(name);
            XmlNode age = xDoc.CreateElement("Age");
            age.InnerText = "34";
            person.AppendChild(age);
            XmlNode email = xDoc.CreateElement("Email");
            email.InnerText = "mike@gmail.com";
            person.AppendChild(email);
            xDoc.DocumentElement.AppendChild(person);
            xDoc.Save("../../../newtext.xml");
        }

        public static void Delete(string name)
        {
            xDoc.Load("../../../newtext.xml");

            foreach (XmlNode item in xDoc.SelectNodes("People/Person"))
            {
                if(item.SelectSingleNode("Name").InnerText==name)
                {
                    item.ParentNode.RemoveChild(item);
                }
            }


            xDoc.Save("../../../newtext.xml");
        }


    }
}
