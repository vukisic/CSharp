using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int id;

        public Person(string firstname, string lastname, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id;
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Id;
        }
    }
}
