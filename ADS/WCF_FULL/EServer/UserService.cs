using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class UserService : IUserService
    {
        static UserService()
        {
            Console.WriteLine("Adding users to DataBase...");
            User admin = new User("admin", "admin");
            admin.AddRight(ERights.Read);
            admin.AddRight(ERights.Write);
            admin.Authentificated = true; //By Default Admin has all Rights!
            DataBase.user_DB.Add(admin.Username, admin);
            User client = new User("pera", "pera");
            client.AddRight(ERights.Read);
            DataBase.user_DB.Add(client.Username, client);
        }


        public string LogIn(string username, string password)
        {
            if(DataBase.user_DB.ContainsKey(username))
            {
                if(DataBase.user_DB[username].Password==password)
                {
                    DataBase.user_DB[username].Authentificated = true;
                    return "Success!!!";
                }
                else
                {
                    DataException ex = new DataException("Invalid PASSWORD!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("Invalid USERNAME!");
                throw new FaultException<DataException>(ex);
            }
        }

        public static bool IsAuthentificated(string username)
        {
            if (DataBase.user_DB.ContainsKey(username))
                return DataBase.user_DB[username].Authentificated;
            else
                return false;
        }

        public static bool IsAuthorized(string username,ERights right)
        {
            if (DataBase.user_DB.ContainsKey(username))
                return DataBase.user_DB[username].HasRight(right);
            else
                return false;
        }

    }
}
