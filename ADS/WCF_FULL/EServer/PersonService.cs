using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class PersonService : IPersonService
    {
        private static List<Person> Removed = new List<Person>();

        public void AddPerson(Person p, string username)
        {
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Write))
                {
                    Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
                    Console.WriteLine("\t->Add/Modify Person wit id: " + p.Id + " !");
                    p.Time = DateTime.Now;
                    DataBase.person_DB[p.Id] = p; //Add/Modify!
                }
                else
                {
                    DataException ex = new DataException("User is not Authorized(Write)!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("User is not Authentificated!");
                throw new FaultException<DataException>(ex);
               
            }
        }

        public List<Person> GetAll(string username)
        {
            if(UserService.IsAuthentificated(username))
            {
                if(UserService.IsAuthorized(username,ERights.Read))
                {
                    Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
                    Console.WriteLine("\t->Get All Persons!");
                    return DataBase.person_DB.Values.ToList();
                }
                else
                {
                    DataException ex = new DataException("User is not Authorized(Read)!");
                    throw new FaultException<DataException>(ex);
                }
            }
            else
            {
                DataException ex = new DataException("User is not Authentificated!");
                throw new FaultException<DataException>(ex);
                
            }
        }

        public Dictionary<long, Person> GetData(DateTime time)
        {
            Console.WriteLine("-- "+DateTime.Now.ToString()+" --");
            Console.WriteLine("\t->Get Data!");
            Dictionary<long, Person> dict = new Dictionary<long, Person>();
            foreach (var item in DataBase.person_DB.Values)
            {
                if(item.Time>time)
                {
                    dict.Add(item.Id, item);
                }
            }

            foreach (var item in Removed)
            {
                dict.Add(item.Id, item);
            }
            Removed.Clear();
            return dict;
        }

        public void RemovePerson(long id, string username)
        {
            
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Write))
                {
                    if(DataBase.person_DB.ContainsKey(id))
                    {
                        Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
                        Console.WriteLine("\t->Remove Person wit id: " + id + " !");
                        Person p = DataBase.person_DB[id];
                        DataBase.person_DB.Remove(id);
                        p.Removed = true;
                        Removed.Add(p);
                    }
                    else
                    {
                        DataException ex = new DataException("ERROR: Person with ID:"+id+" doesn't exist!");
                        throw new FaultException<DataException>(ex);
                    }
                }
                else
                {
                    DataException ex = new DataException("User is not Authorized(Write)!");
                    throw new FaultException<DataException>(ex);
                    
                }
            }
            else
            {
                DataException ex = new DataException("User is not Authentificated!");
                throw new FaultException<DataException>(ex);
            }
        }

        public void SetData(Dictionary<long, Person> dict)
        {
            Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
            Console.WriteLine("\t->Set Data!");
            foreach (var item in dict.Values)
            {
                if (item.Removed)
                    RemovePerson(item.Id, "admin"); //Default is Admin!
                else
                    AddPerson(item, "admin"); //Default is Admin!
            }
        }
    }
}
