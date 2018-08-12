using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServiceState : IServiceState
    {
        private static ServiceConfiguration config = new ServiceConfiguration();

        public static ServiceConfiguration Config { get => config;}

        public EState GetState()
        {
            return config.State;
        }

        public void SetState(EState state)
        {
            config.State = state;
        }
    }
}
