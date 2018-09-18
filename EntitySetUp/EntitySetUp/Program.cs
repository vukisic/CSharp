using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySetUp
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }
    }

    public class ItemDbContex : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
