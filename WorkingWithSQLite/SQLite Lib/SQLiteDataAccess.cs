using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Lib
{
    public class SQLiteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn=new SQLiteConnection(ConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConnectionString()))
            {
                cnn.Execute("insert into Person (FirstName,LastName) values (@FirstName, @LastName)", person);
            }
        }

        public static void DeletePerson(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConnectionString()))
            {
                cnn.Execute("delete from Person where Id= "+id.ToString());
            }
        }
        private static string ConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
