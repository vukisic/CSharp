using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hPerson = new ServiceHost(typeof(PersonService));

            hPerson.Open();
            Console.WriteLine("Server is Open!");
            Console.ReadLine();
            hPerson.Close();
        }
    }
}
