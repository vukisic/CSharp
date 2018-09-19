using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTests
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstname,string lastname,int id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Id = id;
        }

        public Person()
        {
            this.Id = 0;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " ID: " + Id;
        }
    }
}
