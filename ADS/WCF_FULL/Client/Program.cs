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
        static IPersonService p;
        static IUserService u;
        static void Main(string[] args)
        { 

            string auth = String.Empty;

            try
            {
                SafeConnect("pera", "perA");
                auth = u.LogIn("pera", "perA");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            try
            {
                SafeConnect("pera", "pera");
                auth = u.LogIn("pera", "pera");
                Console.WriteLine(auth);
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine(ex.Detail.Reason);
            }

            for (int i = 0; i < 10; ++i)
            {
                Person pt = new Person("Vuk", "Isic", 2610 + i);
                try
                {
                    SafeConnect("admin","admin");
                    p.AddPerson(pt,"admin");
                }
                catch (FaultException<DataException> ex)
                {
                    Console.WriteLine(ex.Detail.Reason);
                }

                Thread.Sleep(2000);
            }


            for (int i = 0; i < 4; ++i)
            {
                try
                {
                    SafeConnect("admin","admin");
                    p.RemovePerson(2610 + i,"admin");
                }
                catch (FaultException<DataException> ex)
                {
                    Console.WriteLine(ex.Detail.Reason);
                }

                Thread.Sleep(2000);
            }

            List<Person> list = new List<Person>();
            SafeConnect("pera","pera");
            list = p.GetAll("pera");
            Console.WriteLine("\n\nPersons:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void SafeConnect(string user,string pass)
        {
            bool connected = false;
            while (!connected)
            {
                for (int i = 1; i < 3; ++i)
                {
                    ChannelFactory<IPersonService> ptemp = new ChannelFactory<IPersonService>("PServer" + i.ToString());
                    ChannelFactory<IUserService> utemp = new ChannelFactory<IUserService>("UServer" + i.ToString());
                    p = ptemp.CreateChannel();
                    u = utemp.CreateChannel();
                    try
                    {
                        u.LogIn(user, pass);
                        p.RemovePerson(1,user); //Test
                        Console.WriteLine("Connected to Server" + i.ToString());
                        connected = true;
                        return;

                    }
                    catch (FaultException<DataException> ex)
                    {
                        Console.WriteLine("Connected to Server" + i.ToString());
                        connected = true;
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot connect to Server" + i.ToString());
                        connected = false;
                        continue;
                    }
                }
            }
        }
    }
}
