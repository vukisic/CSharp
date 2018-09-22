using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReturnValueThreading
{
    public delegate void SumOfNumbers(int sum);

    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum : " + sum);
        }

        static void Main(string[] args)
        {
            Console.Write("Number : ");
            int target = Int32.Parse(Console.ReadLine());
            SumOfNumbers callback = new SumOfNumbers(PrintSum);


            Numbers n = new Numbers(target, callback);
            Thread t = new Thread(() => n.Sum());
            t.Start();


        }
    }

    public class Numbers
    {
        private int _target;
        SumOfNumbers _callback;

        public Numbers(int target,SumOfNumbers sumOfNumbers)
        {
            _target = target;
            _callback = sumOfNumbers;
        }

        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < _target; ++i)
                sum += (i + 1);
            if (_callback != null)
                _callback(sum);
        }
    }

}
