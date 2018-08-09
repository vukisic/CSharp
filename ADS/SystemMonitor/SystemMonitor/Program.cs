using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class Program
    {
        static IServiceState primary = null;
        static IServiceState secondary = null;
        static void Main(string[] args)
        {
            if(TryToConnect("Primary",EState.Primary,out primary))
            {
                TryToConnect("Secondary", EState.Secondary, out secondary);
            }
            else
            {
                TryToConnect("Secondary", EState.Primary, out primary);
            }

            while(true)
            {
                EState pState = EState.Unknow;
                EState sState = EState.Unknow;

                try
                {
                    pState = primary.GetState();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Primary is not operative!");
                }

                try
                {
                    sState = secondary.GetState();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Secondary is not operative!");
                }

                Console.WriteLine("State Report:");
                Console.WriteLine("\t->Primary: "+pState.ToString());
                Console.WriteLine("\t->Secondary: "+sState.ToString());

                if(pState==EState.Unknow || sState==EState.Unknow)
                {
                    if(pState==EState.Unknow)
                    {
                        if (sState == EState.Secondary)
                            secondary.SetState(EState.Primary);
                        if (TryToConnect("Primary", EState.Primary, out primary))
                            secondary.SetState(EState.Secondary);
                    }

                    if(sState==EState.Unknow)
                    {
                        if (pState == EState.Secondary)
                            primary.SetState(EState.Primary);
                        TryToConnect("Secondary", EState.Secondary, out secondary);
                    }
                }



                Thread.Sleep(3000);
            }

        }


        static bool TryToConnect(string endpoint,EState state,out IServiceState target)
        {
            target = null;
            try
            {
                ChannelFactory<IServiceState> temp = new ChannelFactory<IServiceState>(endpoint);
                target = temp.CreateChannel();
                target.SetState(state);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(endpoint+" is not connected!");
                return false;
            }
        }

    }
}
