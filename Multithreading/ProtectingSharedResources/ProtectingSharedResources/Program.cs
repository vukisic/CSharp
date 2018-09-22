using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProtectingSharedResources
{
    class Program
    {
        static int Total = 0;
        static object _lock = new object();


        //1. Way -> Interlocked -> BETTER PERFORMANCE
        //public static void AddMillion()
        //{
        //    for (int i = 0; i < 1000000; ++i)
        //        Interlocked.Increment(ref Total);
        //}

        //2. Way -> Lock
        public static void AddMillion()
        {
            for (int i = 0; i < 1000000; ++i)
            {
                lock(_lock)
                {
                    ++Total;
                }
            }
        }



        static void Main(string[] args)
        {
            Thread t1 = new Thread(AddMillion);
            Thread t2 = new Thread(AddMillion);
            Thread t3 = new Thread(AddMillion);

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
