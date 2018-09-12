using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var specificBook = books.Single(x => x.Title == "Book1");
            var specificBook1 = books.SingleOrDefault(x => x.Title == "Book4");
            if(specificBook1==null)
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine("Found!");

            Console.WriteLine(books.First(x => x.Price<200).Title);
            Console.WriteLine(books.FirstOrDefault(x => x.Price<100)==null);
            Console.WriteLine();
            var filtered = books.Skip(2).Take(3);
            foreach (var item in filtered)
            {
                Console.WriteLine(item.Title);
            }

            var book = books.Max(b => b.Price);
            Console.WriteLine(book);

            var sum = books.Sum(b => b.Price);
            Console.WriteLine(sum);

            #region LINQ Exampes
            //LINQ Query
            //var cheap = from b in books
            //            where b.Price < 200
            //            orderby b.Price
            //            select b.Price;
            //Console.WriteLine();
            //foreach (var item in cheap)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //LINQ Extensions
            //var cheapBooks = books.Where(x => x.Price < 200);
            //var titles = books
            //        .Where(x => x.Price < 200)
            //        .Select(x => x.Title);
            //cheapBooks
            //    .OrderBy(x => x.Price);

            //PrintList<Book>(books);
            //PrintList<Book>(cheapBooks);
            //Console.WriteLine();
            //foreach (var item in titles)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }

        public static void PrintList<T>(IEnumerable<T> list) where T : Book
        {
            Console.WriteLine();
            foreach (T item in list)
            {
                Console.Write(item.Title+" "+item.Price+" | ");
            }
            Console.WriteLine();
        }
    }
}
