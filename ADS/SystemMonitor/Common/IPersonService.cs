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
        void RemovePerosn(long id);

        [OperationContract]
        [FaultContract(typeof(DataException))]
        List<Person> GetAll();
    }
}
