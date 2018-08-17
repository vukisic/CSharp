using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;

namespace DB_Intro_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connect = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            using (DbConnection sql=factory.CreateConnection())
            {
                if(sql==null)
                {
                    Console.WriteLine("Connection Error!");
                    Console.ReadLine();
                    return;
                }

                sql.ConnectionString = connect;
                sql.Open();

                DbCommand com1 = factory.CreateCommand();
                if (com1 == null)
                {
                    Console.WriteLine("Command Error!");
                    Console.ReadLine();
                    return;
                }

                com1.Connection = sql;
                com1.CommandText = "Select * from Products";

                using (DbDataReader reader=com1.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} " + $"{reader["Name"]}");
                    }
                }


            }



            //Console.ReadLine();
        }
    }
}
