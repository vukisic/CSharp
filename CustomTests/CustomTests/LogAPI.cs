using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTests
{
    public class LogAPI
    {
        private string path = "../../../log.txt";
        public LogAPI()
        {
            File.Create(path).Close();
        }

        public void Log(string message)
        {
            File.AppendAllText(path,"\t -> "+DateTime.Now.ToString()+" -> "+ message+Environment.NewLine);
        }
    }
}
