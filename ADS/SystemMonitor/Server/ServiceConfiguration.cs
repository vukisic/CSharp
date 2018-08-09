using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServiceConfiguration
    {
        private EState state;

        public ServiceConfiguration()
        {
            this.state = Properties.Settings.Default.State;
            Console.WriteLine("Default State: " + state.ToString());
        }

        public EState State { get => state; set => state = value; }
    }
}
