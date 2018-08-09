using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Replicator
{
    class Program
    {
        static IPersonService iSource;
        static IPersonService iDestination;
        static DateTime LastReplication = new DateTime();
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    ChannelFactory<IPersonService> pSource = new ChannelFactory<IPersonService>("Source");
                    ChannelFactory<IPersonService> pDest = new ChannelFactory<IPersonService>("Destination");

                    iSource = pSource.CreateChannel();
                    iDestination = pDest.CreateChannel();

                    Dictionary<long, Person> dict = new Dictionary<long, Person>();
                    dict = iSource.Get(LastReplication);
                    if(dict.Count>0)
                    {
                        Console.WriteLine("Replicated items: "+dict.Count);
                        iDestination.Set(dict);
                    }

                    LastReplication = DateTime.Now;
                }
                catch (FaultException<DataException> ex)
                {
                    Console.WriteLine("ERROR: "+ex.Detail.Reason);
                }
                finally
                {
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
