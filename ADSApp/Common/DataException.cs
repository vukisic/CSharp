using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /* Exception class for Data and Security Exceptions */
    [DataContract]
    public class DataException
    {
        private string reason;

        public DataException(string reason)
        {
            this.reason = reason;
        }

        [DataMember]
        public string Reason { get => reason; set => reason = value; }
    }
}
