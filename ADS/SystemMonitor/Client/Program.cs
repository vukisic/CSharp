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
        static IPersonService temp;
        static void Main(string[] args)
        {
            for(int i=0;i<10;++i)
            {
                Person p = new Person("Vuk", "Isic", 2610 + i);
                try
                {
                    SafeConnect();
                    temp.AddPerson(p);
                }
                catch (FaultException<DataException> ex)
                {
                    Console.WriteLine(ex.Detail.Reason);
                }

                Thread.Sleep(2000);
            }


            for(int i=0;i<4;++i)
            {
                try
                {
                    SafeConnect();
                    temp.RemovePerosn(2610+i);
                }
                catch (FaultException<DataException> ex)
                {
                    Console.WriteLine(ex.Detail.Reason);
                }

                Thread.Sleep(2000);
            }

            List<Person> list = new List<Person>();
            SafeConnect();
            list = temp.GetAll();
            Console.WriteLine("\n\nPersons:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }



        public static void SafeConnect()
        {
            bool connected = false;
            while(!connected)
            {
                for(int i=1;i<3;++i)
                {
                    ChannelFactory<IPersonService> ptemp = new ChannelFactory<IPersonService>("Server" + i.ToString());
                    temp = ptemp.CreateChannel();
                    try
                    {
                        temp.RemovePerosn(1); //Test
                        Console.WriteLine("Connected to Server"+i.ToString());
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
                        Console.WriteLine("Cannot connect to Server"+i.ToString());
                        connected = false;
                        continue;
                    }
                }
            }
        }
    }
}
