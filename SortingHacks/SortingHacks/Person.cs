using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHacks
{
    public class Person : IComparable
    {
        string first_name;
        string last_name;
        long id;

        public Person()
        {
            this.first_name = "NoName";
            this.last_name = "NoName";
            this.id = 0;
        }

        public Person(string first_name,string last_name,long id)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.id = id;
        }

        public string First_name { get => first_name; set => first_name = value; }

        public string Last_name { get => last_name; set => last_name = value; }

        public long Id { get => id; set => id = value; }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            return p.Id.CompareTo(this.Id);
        }

        public override string ToString()
        {
            return First_name + " " + Last_name + " ID: " + Id;
        }
    }
}
