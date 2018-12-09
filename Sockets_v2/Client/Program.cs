using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static Socket socket;
        static void Main(string[] args)
        {
            OpenSocket();

            Connect();

            SendMessage();

            ReciveMessage();

            CloseSocket();
        }

        private static void OpenSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private static void Connect()
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            socket.Connect(endpoint);
            Console.WriteLine("Connected!");
        }

        private static void SendMessage()
        {
            Console.Write("Enter Message to Send:");
            string message = Console.ReadLine();
            byte[] rawMessage = Encoding.ASCII.GetBytes(message);
            socket.Send(rawMessage, 0, rawMessage.Length, SocketFlags.None);
        }

        private static void ReciveMessage()
        {
            byte[] buffer = new byte[255];
            int recivedBytes = socket.Receive(buffer,0,buffer.Length,SocketFlags.None);

            Array.Resize(ref buffer, recivedBytes);

            string recivedMessage = Encoding.ASCII.GetString(buffer);
            Console.WriteLine($"Recived: {recivedMessage}");
        }

        private static void CloseSocket()
        {
            socket.Close();
        }
    }
}
