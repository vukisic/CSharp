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
        public static List<Person> Removed = new List<Person>();

        public void AddPerson(Person p)
        {
            if(!DataBase.Person_DB.ContainsKey(p.Id))
            {
                Console.WriteLine("-- "+DateTime.Now.ToString()+" --");
                Console.WriteLine("\tAdd Person with ID: "+p.Id);
                p.Time = DateTime.Now;
                DataBase.Person_DB[p.Id] = p;
            }
            else
            {
                DataException ex = new DataException("Person with that ID, already exist!");
                throw new FaultException<DataException>(ex);
            }
        }

        public Dictionary<long, Person> Get(DateTime time)
        {
            Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
            Console.WriteLine("\tData TO Dictionary!");
            Dictionary<long, Person> ret = new Dictionary<long, Person>();
            foreach (var item in DataBase.Person_DB.Values)
            {
                if (item.Time > time)
                    ret.Add(item.Id, item);
            }
            foreach (var item in Removed)
            {
                ret.Add(item.Id,item);
            }
            Removed.Clear();
            return ret;
        }

        public List<Person> GetAllPersons()
        {
            Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
            Console.WriteLine("\tGet All Persons");
            return DataBase.Person_DB.Values.ToList();
        }

        public void RemovePerson(long id)
        {
            if(DataBase.Person_DB.ContainsKey(id))
            {
                Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
                Console.WriteLine("\tRemove Person with ID: "+ id);
                Person p = DataBase.Person_DB[id];
                DataBase.Person_DB.Remove(id);
                p.Removed = true;
                Removed.Add(p);
            }
            else
            {
                DataException ex = new DataException("Person with that ID, doesn't exist!");
                throw new FaultException<DataException>(ex);
            }
        }

        public void Set(Dictionary<long, Person> dict)
        {
            Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
            Console.WriteLine("\tLoad Data FORM Dictionary");
            foreach (var item in dict.Values)
            {
                if (!item.Removed)
                    AddPerson(item);
                else
                    RemovePerson(item.Id);
            }
        }



    }
}
