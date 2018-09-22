using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorVsLock
{
    class Program
    {
        /* lock -> just shortcut for Monitor.Enter and try-finally */
        static int Total = 0;
        static object _lock = new object();

        public static void AddOneMillion()
        {
            for(int i=0;i<1000000;++i)
            {
                Monitor.Enter(_lock);
                try
                {
                    ++Total;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(AddOneMillion);
            Thread t2 = new Thread(AddOneMillion);
            Thread t3 = new Thread(AddOneMillion);


            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(Total);
        }
    }
}
