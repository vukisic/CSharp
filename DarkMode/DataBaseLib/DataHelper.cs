using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib
{
    public class DataHelper
    {
        public static List<SubjectModel> LoadData()
        {
            using (IDbConnection cnn=new SQLiteConnection(ConnectionString()))
            {
                var output = cnn.Query<SubjectModel>("select * from Subject", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveData(SubjectModel subject)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConnectionString()))
            {
                cnn.Execute("insert into Subject (SubjectName,Grade) values (@SubjectName,@Grade)",subject);
            }
        }

        public static void DeleteData(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConnectionString()))
            {
                string fullName = "\"" + name + "\"";
                try
                {
                    cnn.Execute($"delete from Subject where SubjectName={ fullName }");
                }
                catch (Exception)
                {
                    throw new Exception("Not Found Item !");
                }
                
            }
        }

        private static string ConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
