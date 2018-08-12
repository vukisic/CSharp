using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Vuk", "Isic", 2611);
            Person p2 = new Person("Vuk", "Isic", 2612);
            Person p3 = new Person("Vuk", "Isic", 2613);
            Person p4 = new Person("Vuk", "Isic", 2614);
            Person p5 = new Person("Vuk", "Isic", 2615);

            List<Person> list = new List<Person>();
            List<Person> list2 = new List<Person>();
            list.Add(p1);
            list.Add(p3);
            list.Add(p2);
            list.Add(p5);
            list.Add(p4);

            list2.Add(p1);
            list2.Add(p3);
            list2.Add(p2);
            list2.Add(p5);
            list2.Add(p4);

            Console.WriteLine("UnSorted List:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // IComparable Method!
            list.Sort();

            Console.WriteLine("Sorted List:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("UnSorted List2:");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            // Lambda Method!
            list2.Sort((emp1, emp2) => emp2.Id.CompareTo(emp1.Id));

            Console.WriteLine("Sorted List2:");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
