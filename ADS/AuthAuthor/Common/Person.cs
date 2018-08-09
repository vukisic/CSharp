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
        private string first_name;
        private string last_name;
        private long id;

        public Person()
        {
            this.first_name = "";
            this.last_name = "";
            this.id = 0;
        }

        public Person(string first_name,string last_name,long id)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.id = id;
        }

        [DataMember]
        public string First_name { get => first_name; set => first_name = value; }

        [DataMember]
        public string Last_name { get => last_name; set => last_name = value; }

        [DataMember]
        public long Id { get => id; set => id = value; }

        public override string ToString()
        {
            return First_name + " " + Last_name + " ID:" + Id;
        }
    }
}
