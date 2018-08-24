using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace WorkingWithJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../MyFile.json";
            //JavaScriptSerializer don't implement IDisposable inteface!!!
            JavaScriptSerializer ser = new JavaScriptSerializer();

            //Serialize JSON file

            //System.Web.Script.Serialization
            Person temp = new Person { Name = "Vuk", Age = 22 };
            string JSONoutput = ser.Serialize(temp);
            File.WriteAllText(path, JSONoutput);

            //Newtonsoft.Json
            string JSONout = JsonConvert.SerializeObject(temp);
            File.WriteAllText(path, JSONout);




            //Deserialize JSON file
            string JSONstring = File.ReadAllText(path);

            //System.Web.Script.Serialization
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine("System: "+ p1);

            //Newtonsoft.Json
            Person p2 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine("Newton.Json: "+p2);
        }
    }
}
