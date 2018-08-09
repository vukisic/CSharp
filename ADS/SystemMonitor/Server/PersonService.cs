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
        public void AddPerson(Person p)
        {
            if(DataBase.Person_DB.ContainsKey(p.Id))
            {
                DataException ex = new DataException("Person with that Id, already exist!");
                throw new FaultException<DataException>(ex);
            }
            else
            {
                Console.WriteLine("-- "+DateTime.Now.ToString()+" --");
                Console.WriteLine("\tAdd Person with ID:"+p.Id);
                DataBase.Person_DB.Add(p.Id, p);
            }
        }

        public List<Person> GetAll()
        {
            Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
            Console.WriteLine("\tGet All Persons!");
            return DataBase.Person_DB.Values.ToList();
        }

        public void RemovePerosn(long id)
        {
            if(DataBase.Person_DB.ContainsKey(id))
            {
                Console.WriteLine("-- " + DateTime.Now.ToString() + " --");
                Console.WriteLine("\tRemove Person with ID:"+id);
                DataBase.Person_DB.Remove(id);
            }
            else
            {
                DataException ex = new DataException("Person with that Id, doesn't exist!");
                throw new FaultException<DataException>(ex);
            }
        }
    }
}
