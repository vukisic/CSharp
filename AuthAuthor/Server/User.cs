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
        private HashSet<ERights> rights = new HashSet<ERights>();

        public User(string username,string password)
        {
            this.username = username;
            this.password = password;
            this.authentificated = false;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool Authentificated { get => authentificated; set => authentificated = value; }

        public void AddRights(ERights right)
        {
            if (!rights.Contains(right))
                rights.Add(right);
        }

        public bool HasRight(ERights right)
        {
            return rights.Contains(right);
        }
    }
}
