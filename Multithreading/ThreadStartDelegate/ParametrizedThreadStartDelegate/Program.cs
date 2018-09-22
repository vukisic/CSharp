using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParametrizedThreadStartDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart t = new ParameterizedThreadStart(Numbers.PrintNumbers);
            Thread t1 = new Thread(t);
            object target = "20";
            t1.Start(target);
        }
    }

    public class Numbers
    {
        public static void PrintNumbers(object target)
        {
            Int32.TryParse(target.ToString(), out int num);
            for (int i = 0; i < num; ++i)
                Console.WriteLine(i + 1);
        }
    }
}
