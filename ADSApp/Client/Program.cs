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
            ChannelFactory<IUserService> uFactory = new ChannelFactory<IUserService>("UserService");
            ChannelFactory<IPersonService> PFactory = new ChannelFactory<IPersonService>("PersonService");

            IUserService user = uFactory.CreateChannel();
            IPersonService person = PFactory.CreateChannel();

            string auth = String.Empty;

            try
            {
                auth=user.LogIn("admin", "admin");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                auth = user.LogIn("pera", "pera");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                auth = user.LogIn("pera", "pera3");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                List < Person >list = new List<Person>();
                list=person.PersonsToList("pera");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                person.PrintPersonsInJSON("pera", "start.json");
            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }


            try
            {
                Person person1 = new Person("Nikola", "Arsic", 1010);
                person.AddPerson("admin", person1);
                List<Person> list = new List<Person>();
                list = person.PersonsToList("pera");
                Console.WriteLine();
                Console.WriteLine();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                person.RemovePerson("admin",3131);
                List<Person> list = new List<Person>();
                list = person.PersonsToList("pera");
                Console.WriteLine();
                Console.WriteLine();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

            }
            catch (FaultException<DataException> ex)
            {

                Console.WriteLine(ex.Detail.Reason);
            }

            Console.ReadLine();


        }
    }
}
