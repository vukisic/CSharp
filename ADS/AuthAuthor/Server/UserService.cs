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
            Console.WriteLine("Adding Users to Server!");

            User admin = new User("admin", "admin");
            admin.AddRights(ERights.Read);
            admin.AddRights(ERights.Write);
            DataBase.User_DB.Add("admin", admin);

            User pera = new User("pera", "pera");
            pera.AddRights(ERights.Read);
            DataBase.User_DB.Add("pera", pera);

        }

        public string Authentificate(string username, string password)
        {
            Console.WriteLine("Authentificating...");
            if(DataBase.User_DB.ContainsKey(username))
            {
                if(DataBase.User_DB[username].Password==password)
                {
                    DataBase.User_DB[username].Authentificated = true;
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
            return DataBase.User_DB[username].Authentificated;
        }

        public static bool IsAuthorized(string username,ERights right)
        {
            return DataBase.User_DB[username].HasRight(right);
        }

    }
}
