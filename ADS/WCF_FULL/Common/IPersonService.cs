﻿using System;
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
        void AddPerson(Person p, string username);

        [OperationContract]
        [FaultContract(typeof(DataException))]
        void RemovePerson(long id, string username);

        [OperationContract]
        [FaultContract(typeof(DataException))]
        List<Person> GetAll(string username);

        [OperationContract]
        void SetData(Dictionary<long, Person> dict);

        [OperationContract]
        Dictionary<long, Person> GetData(DateTime time);
    }
}
