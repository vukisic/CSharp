using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
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

        [DataMember]
        public string Firstname { get => firstname; set => firstname = value; }
        [DataMember]
        public string Lastname { get => lastname; set => lastname = value; }
        [DataMember]
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Id.ToString();
        }
    }
}
