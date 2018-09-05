using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public enum ERights
    {
        Read,
        Write
    }
    public class User
    {
        private string username;
        private string password;
        private bool authentificated;
        private HashSet<ERights> rights=new HashSet<ERights>();

        /* -> Add MD5 Hash */
        public User(string username,string password)
        {
            this.username = username;
            this.password = password;
            this.authentificated = false;
        }

        public string Username { get => username; }
        public string Password { get => password;}
        public bool Authentificated { get => authentificated; set => authentificated = value; }

        public void AddRight(ERights right)
        {
            if (!rights.Contains(right))
                rights.Add(right);
        }

        public bool HaveRight(ERights right)
        {
            return rights.Contains(right);
        }
    }
}
