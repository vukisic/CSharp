using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_GUI
{
    public partial class Form1 : Form
    {
        Socket socket, acc;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private Socket MakeSocket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = Encoding.Default.GetBytes(textBox1.Text);
            acc.Send(dataToSend, 0, dataToSend.Length, SocketFlags.None);
            textBox1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
            acc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socket = MakeSocket();
            socket.Bind(new IPEndPoint(IPAddress.Any, 8000));
            socket.Listen(0);

            new Thread(() =>
            {
                acc = socket.Accept();
                label1.Text = "Connected !";
                button2.Enabled = true;
                label1.ForeColor = Color.Green;
                socket.Close();

                while(true)
                {
                    try
                    {
                        byte[] buffer = new byte[255];
                        int recived = acc.Receive(buffer);

                        Array.Resize(ref buffer, recived);

                        Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(Encoding.Default.GetString(buffer));
                        });
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Disconnected!","Server");
                        Environment.Exit(0);
                    }
                    
                }

            }).Start();
        }

    }
}
