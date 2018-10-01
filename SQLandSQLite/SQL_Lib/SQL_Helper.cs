using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lib
{
    public class SQL_Helper
    {
        public static List<DataModel> LoadData()
        {
            using (IDbConnection cnn=new SqlConnection(ConnectionString()))
            {
                var result = cnn.Query<DataModel>("select * from Items", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void SaveData(DataModel item)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionString()))
            {
                cnn.Execute("insert into Items (Name,Code) values (@Name,@Code)", item);
            }
        }

        public static void DeleteData(string name)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionString()))
            {
                string fullName = "\'" + name + "\'";
                try
                {
                    cnn.Execute($"delete from Items where Name={fullName}", new DynamicParameters());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        private static string ConnectionString(string id="Defaultsql")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
