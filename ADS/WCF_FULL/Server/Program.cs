using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hPerson = new ServiceHost(typeof(PersonService));
            ServiceHost hUser = new ServiceHost(typeof(UserService));
            ServiceHost hState = new ServiceHost(typeof(ServiceState));

            hState.Open();
            hUser.Open();
            hPerson.Open();

            Console.WriteLine("Server is Open!");
            StartChecking();
            Console.ReadLine();

            hState.Close();
            hUser.Close();
            hPerson.Close();


        }

        public static void StartChecking()
        {
            while (true)
            {
                Console.WriteLine(ServiceState.Config.State.ToString());
                Thread.Sleep(3000);
            }
        }
    }
}
