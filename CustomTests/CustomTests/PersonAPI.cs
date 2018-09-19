using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CustomTests
{
    public class PersonAPI
    {
        private PersonDbContext _context;

        public PersonAPI()
        {
            _context = new PersonDbContext();
        }

        public void AddPerson(Person person)
        {
            var result = _context.Persons.ToList().SingleOrDefault(x => x.Id == person.Id);
            if(result==null)
            {
                _context.Persons.Add(person);
            }
            else
            {
                result.FirstName = person.FirstName;
                result.LastName = person.LastName;
                result.Id = person.Id;

            }
            _context.SaveChanges();
        }

        public void RemovePerson(int id)
        {
            var result = _context.Persons.ToList().SingleOrDefault(x => x.Id == id);
            if (result == null)
            {
                throw new AccessViolationException("User with Id: " + id + ", doesn't exists!");
            }
            else
            {

                _context.Persons.Remove(result);
                _context.SaveChanges();
            }
           

        }

        public List<Person> PersonsList()
        {
            var result = _context.Persons.ToList();
            return result;
        }

        public Dictionary<int,Person> PersonsDictioary()
        {
            var result = _context.Persons.ToDictionary(x => x.Id,x=> x);
            return result;
        }

        public void PrintPersonsInJson(string path)
        {
            try
            {
                string JsonString = JsonConvert.SerializeObject(PersonsList());
                File.WriteAllText(path, JsonString);
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Error! Cannot write to file with path: "+path);
            }
           
        }



    }
}
