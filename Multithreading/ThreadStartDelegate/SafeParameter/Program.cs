using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SafeParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers n = new Numbers(20);
            Thread t1 = new Thread(n.PrintNumbers);
            t1.Start();
        }
    }

    public class Numbers
    {
        private int _target;

        public Numbers(int target)
        {
            _target = target;
        }

        public void PrintNumbers()
        {
            for (int i = 0; i < _target; ++i)
                Console.WriteLine(i + 1);
        }
    }
}
