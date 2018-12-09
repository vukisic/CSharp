using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static byte[] Buffer { get; set; }
        static Socket socket;

        static void Main(string[] args)
        {
            /* InterNetwork -> IPv4 */
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, 1234));
            socket.Listen(100);

            /* Blocking call */
            Socket accepted = socket.Accept();
            Buffer = new byte[accepted.SendBufferSize];

            /* Recive */
            int bytesRecived = accepted.Receive(Buffer);

            /* Formating */
            byte[] formatted = new byte[bytesRecived];
            for(int i=0;i<bytesRecived;++i)
            {
                formatted[i] = Buffer[i];
            }

            string recStr = Encoding.ASCII.GetString(formatted);
            Console.WriteLine($"Recived: {recStr} {Environment.NewLine}");
            Console.ReadLine();
            socket.Close();
            accepted.Close();

        }
    }
}
