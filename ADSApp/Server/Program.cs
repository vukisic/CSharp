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
            ServiceHost hUser = new ServiceHost(typeof(UserService));
            ServiceHost hPerson = new ServiceHost(typeof(PersonService));

            hUser.Open();
            hPerson.Open();

            Console.WriteLine("Server is started!");
            Console.ReadLine();

            hPerson.Close();
            hUser.Close();
        }
    }
}
