using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee{Id=1,Name="Mark"},
                new Employee{Id=2,Name="Bill"},
                new Employee{Id=3,Name="Stive"}
            };

            Func<Employee, string> selector = x => "Name :" + x.Name;
            var tempList = list.Select(selector);
            foreach (var item in tempList)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
