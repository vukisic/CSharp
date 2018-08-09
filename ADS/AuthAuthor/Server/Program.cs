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
            ServiceHost person = new ServiceHost(typeof(PersonService));
            ServiceHost user = new ServiceHost(typeof(UserService));

            user.Open();
            person.Open();
            Console.WriteLine("Server is Started!");
            Console.ReadLine();
            user.Close();
            person.Close();
        }
    }
}
