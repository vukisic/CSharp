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
        public void AddPerson(Person p,string username)
        {
            if(UserService.IsAuthentificated(username))
            {
                if(UserService.IsAuthorized(username,ERights.Write))
                {
                    Console.WriteLine("--"+DateTime.Now.ToString()+"--");
                    Console.WriteLine("\tAdd/Modify Person with ID:"+p.Id);
                    DataBase.Person_DB[p.Id] = p;  //Add or Modify
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

        public List<Person> GetAllPersons(string username)
        {
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Read))
                {
                    Console.WriteLine("--" + DateTime.Now.ToString() + "--");
                    Console.WriteLine("\tGet List of Persons");
                    return DataBase.Person_DB.Values.ToList();
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

        public void RemovePerson(long id, string username)
        {
            if (UserService.IsAuthentificated(username))
            {
                if (UserService.IsAuthorized(username, ERights.Write))
                {
                    if(DataBase.Person_DB.ContainsKey(id))
                    {
                        Console.WriteLine("--" + DateTime.Now.ToString() + "--");
                        Console.WriteLine("\tRemove Person with ID:" + id);
                        DataBase.Person_DB.Remove(id);
                    }
                    else
                    {
                        DataException ex = new DataException("User with that ID, doesn't exist!");
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


    }
}
