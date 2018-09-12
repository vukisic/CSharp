using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // () => ...
            // x => ...
            // (x,y) => ...

            const int factor = 5;
            Func<int, int> Multipiler = m => m * factor;
            Console.WriteLine(Multipiler(3));

            var books = new BookRepository().GetBooks();
            var chiper=books.FindAll(b => b.Price < 20);
            foreach (var item in chiper)
            {
                Console.WriteLine(item.Title + " " +item.Price);
            }
        }
    }
}
