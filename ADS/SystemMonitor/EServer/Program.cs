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
            ServiceHost hState = new ServiceHost(typeof(ServiceState));

            hState.Open();
            hPerson.Open();

            Console.WriteLine("Service is Open!");
            StartChecking();
            Console.ReadLine();

            hPerson.Close();
            hState.Close();

        }

        public static void StartChecking()
        {
            while(true)
            {
                Console.WriteLine(ServiceState.Config.State.ToString());
                Thread.Sleep(3000);
            }
        }
    }
}
