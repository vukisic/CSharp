using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysMonAndReplicator
{
    class Program
    {
        static IServiceState primary_s = null;
        static IServiceState secondary_s = null;
        static IPersonService primary_p = null;
        static IPersonService secondary_p = null;
        static DateTime LastReplication = new DateTime();
        static void Main(string[] args)
        {
            if (TryToConnect("Source_S", EState.Primary, out primary_s))
            {
                TryToConnect("Destination_S", EState.Secondary, out secondary_s);
            }
            else
            {
                TryToConnect("Destination_S", EState.Primary, out primary_s);
            }

            while (true)
            {
                EState pState = EState.Unknow;
                EState sState = EState.Unknow;

                try
                {
                    pState = primary_s.GetState();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Primary is not operative!");
                }

                try
                {
                    sState = secondary_s.GetState();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Secondary is not operative!");
                }

                Console.WriteLine("State Report:");
                Console.WriteLine("\t->Primary: " + pState.ToString());
                Console.WriteLine("\t->Secondary: " + sState.ToString());

                if (pState == EState.Unknow || sState == EState.Unknow)
                {
                    if (pState == EState.Unknow)
                    {
                        if (sState == EState.Secondary)
                            secondary_s.SetState(EState.Primary);
                        if (TryToConnect("Source_S", EState.Primary, out primary_s))
                            secondary_s.SetState(EState.Secondary);
                    }

                    if (sState == EState.Unknow)
                    {
                        if (pState == EState.Secondary)
                            primary_s.SetState(EState.Primary);
                        TryToConnect("Destination_S", EState.Secondary, out secondary_s);
                    }
                }

                if (pState == EState.Primary && sState == EState.Secondary)
                {
                    TryToReplicate("Source_P", primary_p, "Destination_P", secondary_p);
                }
                else if (pState == EState.Secondary && sState == EState.Primary)
                {
                    TryToReplicate("Destination_P", primary_p, "Source_P", secondary_p);
                }

                Thread.Sleep(3000);
            }
        }

        public static bool TryToConnect(string endpoint,EState state,out IServiceState target)
        {
            target = null;
            try
            {
                ChannelFactory<IServiceState> factory = new ChannelFactory<IServiceState>(endpoint);
                target = factory.CreateChannel();
                target.SetState(state);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(endpoint+" is not connected!");
                return false;
            }
        }

        public static void TryToReplicate(string s_endpoint,IPersonService source,string d_endpoint,IPersonService dest)
        {
            try
            {
                ChannelFactory<IPersonService> pSource = new ChannelFactory<IPersonService>(s_endpoint);
                ChannelFactory<IPersonService> pDest = new ChannelFactory<IPersonService>(d_endpoint);

                source = pSource.CreateChannel();
                dest = pDest.CreateChannel();

                Dictionary<long, Person> dict = new Dictionary<long, Person>();
                dict = source.GetData(LastReplication);
                if (dict.Count > 0)
                {
                    Console.WriteLine("Replicated items: " + dict.Count);
                    dest.SetData(dict);
                }

                LastReplication = DateTime.Now;
            }
            catch (FaultException<DataException> ex)
            {
                Console.WriteLine("ERROR: " + ex.Detail.Reason);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR!" + ex.Message);
            }
        }


    }
}
