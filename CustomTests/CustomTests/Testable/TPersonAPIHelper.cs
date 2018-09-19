using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTests.Testable
{
    public class TPersonAPIHelper : ITPersonAPIHelper
    {
        private PersonDbContext _context;

        public TPersonAPIHelper()
        {
            _context = new PersonDbContext(); 
        }

        public void Remove(int id)
        {
            var result = _context.Persons.ToList().SingleOrDefault(x => x.Id == id);
            if (result == null)
            {
                return;
            }
            else
            {

                _context.Persons.Remove(result);
                _context.SaveChanges();
            }
        }

        public void Add(Person person)
        {
            var result = _context.Persons.ToList().SingleOrDefault(x => x.Id == person.Id);
            if (result == null)
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

        public List<Person> ToList()
        {
            var result = _context.Persons.ToList();
            return result;
        }

        public Dictionary<int,Person> ToDictionary()
        {
            var result = _context.Persons.ToDictionary(x => x.Id, x => x);
            return result;
        }

        public void ToJson(string path)
        {
            try
            {
                string JsonString = JsonConvert.SerializeObject(ToList());
                File.WriteAllText(path, JsonString);
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Error! Cannot write to file with path: " + path);
            }
        }
    }
}
