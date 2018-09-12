using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic like in let/var in JavaScript
            dynamic a = 10;
            dynamic b = 5;
            var c = a+b; // C is Dynamic too!

            int d = a;
            Console.WriteLine(d);


        }
    }
}
