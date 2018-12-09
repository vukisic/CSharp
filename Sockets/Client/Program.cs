using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static Socket socket;

        static void Main(string[] args)
        {
            /* Making Socket */
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            /* Making EndPoint */
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            /* Try to Connect */
            try
            {
                socket.Connect(endpoint);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Unable to Connect! {Environment.NewLine} {ex.Message}");
                Main(args);
            }
            Console.WriteLine("Connected!");

            for(int i=0;i<2;++i)
            {
                /* Working on User Input */
                Console.WriteLine("Enter Message:");
                string message = Console.ReadLine();
                byte[] messageToSend = Encoding.ASCII.GetBytes(message);

                /* Send Message */
                socket.Send(messageToSend);
                Console.WriteLine("Message Sent!");
            }
            
            socket.Close();

        }
    }
}
