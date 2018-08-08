using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        [FaultContract(typeof(DataException))]
        void AddPerson(Person p);

        [OperationContract]
        [FaultContract(typeof(DataException))]
        void RemovePerson(long id);

        [OperationContract]
        [FaultContract(typeof(DataException))]
        List<Person> GetAllPersons();

        [OperationContract]
        Dictionary<long, Person> Get(DateTime time);

        [OperationContract]
        void Set(Dictionary<long, Person> dict);
    }
}
