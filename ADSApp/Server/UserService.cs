using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    
    public class UserService : IUserService
    {
        static string ConnectionString=ConfigurationManager.AppSettings["connectionString"];
        static SqlConnection sql;
        static UserService()
        {
            string tempusername;
            string temppassword;
            File.Create("../../../log.txt").Close();
            Console.WriteLine("Reading DataBases...");
            using (sql = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Users", sql))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow item in table.Rows)
                    {
                        tempusername = item["UserName"].ToString();
                        temppassword = item["Password"].ToString();
                        User user = new User(tempusername, temppassword);
                        user.AddRight(ERights.Read);
                        if (tempusername == "admin" || tempusername == "sudo")
                        {
                            user.AddRight(ERights.Write);
                        }
                        DataBaseAdapter.Users.Add(tempusername, user);
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Person", sql))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow item in table.Rows)
                    {
                        string tempfirstname = item["FirstName"].ToString();
                        string templastname = item["LastName"].ToString();
                        int temppid = Int32.Parse(item["PublicId"].ToString());
                        Person person = new Person(tempfirstname, templastname, temppid);
                        DataBaseAdapter.Persons.Add(temppid, person);
                    }
                }
            }
            
            
            Console.WriteLine("Complited!");
        }

        public string LogIn(string username, string password)
        {
            if(DataBaseAdapter.Users.ContainsKey(username))
            {
                if(DataBaseAdapter.Users[username].Password==password)
                {
                    Console.WriteLine(DateTime.Now.ToString());
                    Console.WriteLine("\t LogIn -> {0}", username);
                    DataBaseAdapter.Users[username].Authentificated = true;
                    return "Success!";
                }
                else
                {
                    Common.DataException ex = new Common.DataException("Invalid PASSWORD!");
                    throw new FaultException<Common.DataException>(ex);
                }
            }
            else
            {
                Common.DataException ex = new Common.DataException("Invalid USERNAME!");
                throw new FaultException<Common.DataException>(ex);
            }
        }

        public static bool IsAuthentificated(string username)
        {
            return DataBaseAdapter.Users[username].Authentificated;
        }

        public static bool IsAuthorized(string username,ERights right)
        {
            return DataBaseAdapter.Users[username].HaveRight(right);
        }

    }
}
