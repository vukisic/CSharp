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
        static Socket socket,acc;

        static void Main(string[] args)
        {
            //Opens Sockets, Bind, set Socket to Listen Mode and accept connection
            OpenSockets();

            SendMessage();

            ReciveMessage();

            CloseSockets();
        }

        private static void OpenSockets()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, 1234));
            socket.Listen(0);

            acc = socket.Accept();

        }

        private static void SendMessage()
        {
            byte[] sendBuffer = Encoding.ASCII.GetBytes("Hello !");
            acc.Send(sendBuffer, 0, sendBuffer.Length, SocketFlags.None);
        }

        private static void ReciveMessage()
        {
            byte[] Buffer = new byte[255];
            int recivedBytes = acc.Receive(Buffer,0,Buffer.Length,SocketFlags.None);

            Array.Resize(ref Buffer, recivedBytes);

            string recivedMessage = Encoding.ASCII.GetString(Buffer);
            Console.WriteLine($"Recived: {recivedMessage}");
        }

        private static void CloseSockets()
        {
            socket.Close();
            acc.Close();
        }
    }
}
