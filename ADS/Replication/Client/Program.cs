using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IPersonService> pPerson = new ChannelFactory<IPersonService>("PersonServer");
            IPersonService proxy = pPerson.CreateChannel();

            Console.WriteLine("Adding Persons...");
            for(int i=0;i<15;++i)
            {
                Person p = new Person("Vuk", "Isic", 2610 + i);
                proxy.AddPerson(p);
                Thread.Sleep(1000);
            }


            Console.WriteLine("Removing Persons...");
            for (int i=0;i<7;++i)
            {
                proxy.RemovePerson(2610 + i);
                Thread.Sleep(1000);
            }


            List<Person> list = new List<Person>();
            list = proxy.GetAllPersons();

            Console.WriteLine("\n\nPersons:");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
