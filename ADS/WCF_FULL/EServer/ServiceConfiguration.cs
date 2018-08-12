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
            this.State = Properties.Settings.Default.DefaultState;
            Console.WriteLine("Default State: "+State.ToString());
        }

        public EState State { get => state; set => state = value; }
    }
}
