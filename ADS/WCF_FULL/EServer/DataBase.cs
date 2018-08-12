using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class DataBase
    {
        public static Dictionary<long, Person> person_DB = new Dictionary<long, Person>();
        public static Dictionary<string, User> user_DB = new Dictionary<string, User>();
    }
}
