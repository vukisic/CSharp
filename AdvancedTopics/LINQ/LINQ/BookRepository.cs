using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title="Book1",Price=256},
                new Book{Title="Book2",Price=100},
                new Book{Title="Book8",Price=150},
                new Book{Title="Book5",Price=150},
                new Book{Title="Book6",Price=150},
                new Book{Title="Book7",Price=150},
            };
        }
    }
}
