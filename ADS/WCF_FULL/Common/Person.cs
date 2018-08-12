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
        private bool removed;
        private DateTime time = new DateTime();

        public Person()
        {
            this.first_name = "";
            this.last_name = "";
            this.id = 0;
            this.removed = false;
        }

        public Person(string first_name,string last_name,long id)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.id = id;
            this.removed = false;
        }

        [DataMember]
        public string First_name { get => first_name; set => first_name = value; }

        [DataMember]
        public string Last_name { get => last_name; set => last_name = value; }

        [DataMember]
        public long Id { get => id; set => id = value; }

        [DataMember]
        public bool Removed { get => removed; set => removed = value; }

        [DataMember]
        public DateTime Time { get => time; set => time = value; }

        public override string ToString()
        {
            return first_name + " " + last_name + " " + id;
        }
    }
}
