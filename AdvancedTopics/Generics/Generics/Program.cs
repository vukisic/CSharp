using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        /*Constrains*/
        // where T : IComparable
        // where T : Person
        // where T : struct (value type)
        // where T : class (ref type)
        // where T : new() (obj with default contructor)

        static void Main(string[] args)
        {
            //Nullable Integer
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value : {0}",number.HasValue);
            Console.WriteLine("Value: {0}",number.GetValueOrDefault());

            var tempNumber = new Nullable<int>();
            Console.WriteLine("Has Value : {0}", tempNumber.HasValue);
            Console.WriteLine("Value: {0}", tempNumber.GetValueOrDefault());

        }
    }
}
