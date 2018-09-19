using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CustomTests.Testable
{
    public class TPersonAPI
    {
        private ITPersonAPIHelper _helper;

        public TPersonAPI(ITPersonAPIHelper helper = null)
        {
            _helper = helper ?? new TPersonAPIHelper();
        }

        public void AddPerson(Person person)
        {
            _helper.Add(person);
        }

        public void RemovePerson(int id)
        {
            _helper.Remove(id);
        }

        public List<Person> PersonsList()
        {
            return _helper.ToList();
        }

        public Dictionary<int, Person> PersonsDictioary()
        {
            return _helper.ToDictionary();
        }

        public void PrintPersonsInJson(string path)
        {
            _helper.ToJson(path);

        }



    }
}
