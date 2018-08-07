using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
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
                auth=user.Authentificate("pera", "perA");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                auth=user.Authentificate("pera", "pera");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                auth=user.Authentificate("admin", "admin");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }


            Person p1 = new Person("Vuk", "Isic", 2610);

            try
            {
                person.AddPerson(p1, "pera");
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                person.AddPerson(p1, "admin");
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            Person p2 = new Person("Adam", "Peric", 7007);

            try
            {
                person.AddPerson(p2, "admin");
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }


            try
            {
                List<Person> list=person.GetAllPersons("pera");
                Console.WriteLine("Persons: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                person.RemovePerson(7006, "admin");
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                person.RemovePerson(7007, "admin");
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                List<Person> list = person.GetAllPersons("pera");
                Console.WriteLine("Persons: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
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
