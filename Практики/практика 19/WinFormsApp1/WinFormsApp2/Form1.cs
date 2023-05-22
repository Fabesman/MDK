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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        class ClientInfo
        {
            public Socket socket;
            public string Name;
            public override string ToString()
            {
                return Name + "(" + socket.RemoteEndPoint + ")";
            }
        }
        TcpListener listener;
        List<ClientInfo> clients;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int localPort = int.Parse(textBox2.Text);
                IPEndPoint localPoint = new IPEndPoint(IPAddress.Any, localPort);
                listener = new TcpListener(localPort);
                listener.Start();
                clients = new List<ClientInfo>();
                timer1.Enabled = true;
                textBox1.AppendText("Порт открыт " + textBox2.Text + "\r" + "\n");
            }
            catch (Exception exp)
            {
                textBox1.AppendText(exp.Message + "\r" + "\n");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CheckListener();
                for (int i = clients.Count - 1;i>=0;i--)
                {
                    ClientInfo client = clients[i];
                    if (client.socket.Available >0)
                    {
                        byte[] data = new byte[client.socket.Available];
                        int data_size = client.socket.Receive(data);
                        string text_data = Encoding.UTF8.GetString(data, 0, data_size);
                        DoClient(client, text_data);
                    }
                }
            }
            catch (Exception exp)
            {
                textBox1.AppendText(exp.Message + "\r" + "\n");
            }
        }
        private void CheckListener()
        {
            if (listener.Pending())
            {
                ClientInfo newClient = new ClientInfo();
                newClient.socket = listener.AcceptSocket();
                clients.Add(newClient);
                textBox1.AppendText("Пользователь " + newClient.socket.RemoteEndPoint + " подключился" + "\r" + "\n");
            }
        }
        private void DoClient (ClientInfo client, string text_data)
        {
            if (text_data.StartsWith("Клиент "))
            {
                client.Name = text_data.Substring(6);
                listBox1.Items.Add(client);
                SendToClients("Новый клиент " + client.Name, client);
                textBox1.AppendText("Пользователь " + client.socket.RemoteEndPoint + " с именем " + client.Name + "\r" + "\n");
            }
            if (text_data.StartsWith("Отключение "))
            {
                SendToClients("Отключение " + client.Name, client);
                textBox1.AppendText("Пользователь " + client.socket.RemoteEndPoint + " вышел из чата " + "\r" + "\n");
                client.socket.Close();
                listBox1.Items.Remove(client);
                clients.Remove(client);
            }
            if (text_data.StartsWith("Сообщение "))
            {
                string message = text_data.Substring(9);
                SendToClients("Сообщение от клиента " + client.Name + ": " + message, client);
                textBox1.AppendText(client.Name + ": " + message + "\r" + "\n");
            }
        }
        private void SendToClients(string command, ClientInfo exceptOf)
        {
            for (int i=0;i<clients.Count;i++)
            {
                ClientInfo client = clients[i];
                if (client != exceptOf)
                {
                    try
                    {
                        byte[] data = Encoding.UTF8.GetBytes(command);
                        client.socket.Send(data);
                    }
                    catch (Exception exp)
                    {
                        textBox1.AppendText(exp.Message + "\n");
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
