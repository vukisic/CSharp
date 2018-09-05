using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class DataBaseAdapter
    {
        public static Dictionary<int, Person> Persons = new Dictionary<int, Person>();
        public static Dictionary<string, User> Users = new Dictionary<string, User>();
    }
}
