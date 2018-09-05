using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace DB
{
    
    class Program
    {
        static string ConnectionString=ConfigurationManager.AppSettings["connectionString"];
        static SqlConnection sql;
        static List<Person> list=new List<Person>();
        static void Main(string[] args)
        {
            GetAllFromDB();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            RemoveFromDB(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            AddToDB(new Person("Pera", "Peric", 10));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void GetAllFromDB()
        {
            list.Clear();

            using (sql = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Person", sql))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow item in table.Rows)
                {
                    string tempFirstName = item["FirstName"].ToString();
                    string tempLastName = item["LastName"].ToString();
                    int tempId = Int32.Parse(item["Id"].ToString());
                    Person person = new Person(tempFirstName, tempLastName, tempId);
                    list.Add(person);
                }
            }
        }

        public static void RemoveFromDB(int id)
        {
            using (sql = new SqlConnection(ConnectionString))
            {
                sql.Open();
                using (SqlCommand com = new SqlCommand("Delete from Person where Id=" + id.ToString(), sql))
                {
                    com.ExecuteNonQuery();
                }
                sql.Close();
            }
            
            GetAllFromDB();
        }

        public static void AddToDB(Person person)
        {
            string sqlcommand = "Insert into Person ([FirstName],[LastName]) values (@first,@last)";
            using (sql = new SqlConnection(ConnectionString))
            {
                sql.Open();
                using (SqlCommand com = new SqlCommand(sqlcommand, sql))
                {
                    com.Parameters.AddWithValue("@first", person.Firstname);
                    com.Parameters.AddWithValue("@last", person.Lastname);
                    com.ExecuteNonQuery();
                }
                sql.Close();
            }

            GetAllFromDB();
        }
    }
}
