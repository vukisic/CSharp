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

namespace Client_GUI
{
    public partial class Form1 : Form
    {
        Socket socket;
        public Form1()
        {
            InitializeComponent();
            socket = MakeSocket();
            button2.Enabled = false;
        }

        private Socket MakeSocket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void ReadMessage()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[255];
                    int recived = socket.Receive(buffer);

                    Array.Resize(ref buffer, recived);

                    Invoke((MethodInvoker)delegate
                    {
                        listBox1.Items.Add(Encoding.Default.GetString(buffer));
                    });
                }
                catch (Exception)
                {

                    MessageBox.Show("Disconnected!", "Client");
                    Environment.Exit(0);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Connect(new IPEndPoint(IPAddress.Parse(textBox1.Text), 8000));
                label1.ForeColor = Color.Green;
                label1.Text = "Connected !";
                button2.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Connection Failed!", "Client");
            }

            new Thread(() =>
            {
                ReadMessage();
            }).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(textBox2.Text);
            socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            textBox2.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
        }
    }
}
