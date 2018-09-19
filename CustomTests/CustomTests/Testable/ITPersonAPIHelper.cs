using System.Collections.Generic;

namespace CustomTests.Testable
{
    public interface ITPersonAPIHelper
    {
        void Remove(int id);

        void Add(Person person);

        List<Person> ToList();

        Dictionary<int, Person> ToDictionary();

        void ToJson(string path);
    }
}