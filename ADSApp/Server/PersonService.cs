using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Configuration;

namespace Server
{
    public class PersonService : IPersonService
    {
        static string ConnectionString = ConfigurationManager.AppSettings["connectionString"];
        static SqlConnection sql;
        static string path= "../../../log.txt";
        static string nl = Environment.NewLine;
        public void AddPerson(string username, Person person)
        {
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Write))
                {
                    if(!DataBaseAdapter.Persons.ContainsKey(person.Id))
                    {
                        Console.WriteLine(DateTime.Now.ToString());
                        Console.WriteLine("\t AddPerson Id={0} -> {1}", person.Id, username);
                        File.AppendAllText(path, String.Format("\t"+DateTime.Now.ToString()+" AddPerson Id={0} -> {1}"+nl, person.Id, username));
                        DataBaseAdapter.Persons[person.Id] = person;

                        string sqlcommand = "Insert into Person ([FirstName],[LastName],[PublicId]) values (@first,@last,@public)";
                        using (sql = new SqlConnection(ConnectionString))
                        {
                            sql.Open();
                            using (SqlCommand command = new SqlCommand(sqlcommand, sql))
                            {
                                command.Parameters.AddWithValue("@first", person.Firstname);
                                command.Parameters.AddWithValue("@last", person.Lastname);
                                command.Parameters.AddWithValue("@public", person.Id.ToString());
                                command.ExecuteNonQuery();
                            }
                            sql.Close();
                        }
                    }
                    else
                    {
                        DataException ex = new DataException("Person with Id: " + person.Id +" already exist!");
                        throw new FaultException<DataException>(ex);
                    }
                    
                }
                else
                {
                    DataException ex = new DataException("User " + username + " is not authorized!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("User " + username + " is not authentificated!");
                throw new FaultException<DataException>(ex);
            }
        }

        public List<Person> PersonsToList(string username)
        {
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Read))
                {
                    Console.WriteLine(DateTime.Now.ToString());
                    Console.WriteLine("\t PersonsToList -> {0}", username);
                    File.AppendAllText(path, String.Format("\t"+DateTime.Now.ToString()+" PersonsToList -> {0}"+nl, username));
                    List<Person> list = new List<Person>();
                    list = DataBaseAdapter.Persons.Values.ToList();

                    return list;
                }
                else
                {
                    DataException ex = new DataException("User " + username + " is not authorized!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("User " + username + " is not authentificated!");
                throw new FaultException<DataException>(ex);
            }
        }

        public void PrintPersonsInJSON(string username,string filepath)
        {
            if(UserService.IsAuthentificated(username))
            {
                if(UserService.IsAuthorized(username,ERights.Read))
                {
                    Console.WriteLine(DateTime.Now.ToString());
                    Console.WriteLine("\t PrintPersonsInJSON -> {0}", username);
                    File.AppendAllText(path, String.Format("\t"+DateTime.Now.ToString()+" PrintPersonsInJSON -> {0}"+nl, username));
                    List<Person> list = new List<Person>();
                    list = DataBaseAdapter.Persons.Values.ToList();

                    string data = JsonConvert.SerializeObject(list,Formatting.Indented);
                    File.WriteAllText("../../../"+filepath, data);
                }
                else
                {
                    DataException ex = new DataException("User " + username + " is not authorized!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("User " + username + " is not authentificated!");
                throw new FaultException<DataException>(ex);
            }
        }

        public void RemovePerson(string username, int id)
        {
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Write))
                {
                    if (DataBaseAdapter.Persons.ContainsKey(id))
                    {
                        Console.WriteLine(DateTime.Now.ToString());
                        Console.WriteLine("\t RemovePerson Id={0} -> {1}", id, username);
                        File.AppendAllText(path, String.Format("\t"+DateTime.Now.ToString()+" RemovePerson Id={0} -> {1}"+nl, id, username));
                        DataBaseAdapter.Persons.Remove(id);

                        string sqlcommand = "Delete from Person where PublicId=@public";
                        using (sql = new SqlConnection(ConnectionString))
                        {
                            sql.Open();
                            using (SqlCommand command = new SqlCommand(sqlcommand, sql))
                            {
                                command.Parameters.AddWithValue("@public",id);
                                command.ExecuteNonQuery();
                            }
                            sql.Close();
                        }
                    }
                    else
                    {
                        DataException ex = new DataException("Person with Id: " + id + " doesn't exist!");
                        throw new FaultException<DataException>(ex);
                    }

                }
                else
                {
                    DataException ex = new DataException("User " + username + " is not authorized!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("User " + username + " is not authentificated!");
                throw new FaultException<DataException>(ex);
            }
        }


    }
}
