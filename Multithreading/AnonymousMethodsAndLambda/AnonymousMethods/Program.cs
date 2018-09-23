using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee{Id=1,Name="Mark",Points=100},
                new Employee{Id=2,Name="Bill",Points=80},
                new Employee{Id=3,Name="Stive",Points=85}
            };

            Employee empWithId2 = list.Find(x => x.Id == 2);
            Console.WriteLine(empWithId2.Name);

            var temp=list.Select(x => x.Points += 10);

            var temp1 = list.Where(x => x.Points > 80).ToList();
            foreach (var item in temp1)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Points}");
            }



        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Points { get; set; }
    }

}
