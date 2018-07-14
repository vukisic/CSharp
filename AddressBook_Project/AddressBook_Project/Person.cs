using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Project
{
    public class Person
    {
        private string name;
        private string address;
        private string email;
        private string notes;
        private DateTime birthday;

        public Person()
        {

        }
        public Person(string name, string address,string email,string notes,DateTime birthday)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.notes = notes;
            this.birthday = birthday;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Notes { get => notes; set => notes = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
    }
}
