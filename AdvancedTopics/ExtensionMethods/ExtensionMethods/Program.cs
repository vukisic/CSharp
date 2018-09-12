using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be very long blog post blah blah blah...";
            var shorten = post.Shorten(5);
            Console.WriteLine(shorten);

            //List<int> iList = new List<int>() { 1, 4, 7, 10, 3, 0, -10, 3, 33 };
            //iList.Sort((x, y) => y.CompareTo(x));
            //foreach (var item in iList)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }

}
