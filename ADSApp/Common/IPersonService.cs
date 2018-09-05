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
        void AddPerson(string username,Person person);

        [OperationContract]
        [FaultContract(typeof(DataException))]
        void RemovePerson(string username,int id);

        [OperationContract]
        List<Person> PersonsToList(string username);

        [OperationContract]
        void PrintPersonsInJSON(string username,string filename);
    }
}
