using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Numbers.PrintNumbers));
            t.Start();
            Thread t1 = new Thread(() => Numbers.PrintNumbers());
            t1.Start();
        }
    }

    public class Numbers
    {
        public static void PrintNumbers()
        {
            for(int i=0;i<10;++i)
                Console.WriteLine(i+1);
        }
    }

}
