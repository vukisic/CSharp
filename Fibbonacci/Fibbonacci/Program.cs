using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonacci
{
    class Program
    {
        static double GoldenRatio = (1 + Math.Sqrt(5)) / 2;
        static void Main(string[] args)
        {
            Console.WriteLine("8 => "+IsFibbonaciNum(4));
            for(int i=0;i<8;++i)
                Console.WriteLine(FibbonaciNum(i));
        }


        public static bool IsPerfectSquare(int x)
        {
            int y = (int)Math.Sqrt(x);
            return y * y == x;
        }

        public static string IsFibbonaciNum(int x)
        {
            if (IsPerfectSquare(5 * x * x - 4) || IsPerfectSquare(5 * x * x + 4))
                return "Yes.";
            return "No.";
        }

        public static int FibbonaciNum(int x)
        {
            int[] arr = {0, 1, 1, 2, 3, 5 };
            if (x < 6)
                return arr[x];

            int t = 5, fn = 5;
            while(t<x)
            {
                fn = (int)Math.Round(fn * GoldenRatio);
                t++;
            }

            return fn;
        }
    }
}
