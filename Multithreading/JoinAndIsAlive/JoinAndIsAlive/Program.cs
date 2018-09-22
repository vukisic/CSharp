using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoinAndIsAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started!");

            Thread t1 = new Thread(ThreadFunction1);
            t1.Start();
            t1.Join();

            Thread t2 = new Thread(ThreadFunction2);
            t2.Start();

            if(t2.IsAlive)
                Console.WriteLine("T2 is still Alive!");

            t2.Join();


            Console.WriteLine("Main Complited!");
        }

        public static void ThreadFunction1()
        {
            Console.WriteLine("Function 1");
        }

        public static void ThreadFunction2()
        {
            Console.WriteLine("Function 2");
            Thread.Sleep(5000);
        }
    }
}
