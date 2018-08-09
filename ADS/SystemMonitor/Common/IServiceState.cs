using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract(Name ="EState")]
    public enum EState
    {
        [EnumMember]
        Unknow,
        [EnumMember]
        Primary,
        [EnumMember]
        Secondary
    }

    [ServiceContract]
    public interface IServiceState
    {
        [OperationContract]
        void SetState(EState state);

        [OperationContract]
        EState GetState();
    }
}
