using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title="Book1",Price=10},
                new Book{Title="Book2",Price=20},
                new Book{Title="Book3",Price=17}
            };
        }
    }
}
