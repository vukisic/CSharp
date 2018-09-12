using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date1 = null;
            DateTime date2=date1??DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}
