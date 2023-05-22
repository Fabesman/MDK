using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Klient
{
    public partial class Server : Form
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

        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int localPort = int.Parse(textBox1.Text);
                IPEndPoint localPoint = new IPEndPoint(IPAddress.Any, localPort);
                listener = new TcpListener(localPoint);
                listener.Start();
                clients = new List<ClientInfo>();
                timer1.Enabled = true;
                textBox2.AppendText("Порт открыт " + textBox1.Text + "\r" + "\n");
            }
            catch (Exception exp)
            {
                textBox2.AppendText(exp.Message + "\r" + "\n");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                SendToClients();
                for (int i = clients.Count - 1; i >= 0; i--)
                {
                    ClientInfo client = clients[i];
                    if (client.socket.Available > 0)
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
                textBox2.AppendText(exp.Message + "\r" + "\n");
            }
        }
        private void DoClient(ClientInfo client, string text_data)
        {

            if (text_data.StartsWith("Клиент "))

            {

                client.Name = text_data.Substring(6); // coxpatenne umenm Knanentoe none Name o6vexta
                listBox1.Items.Add(client); // добавление клиента в список клиентов
                SendToClients("Новый клиент" + client.Name, client);
                textBox2.AppendText("Пользователь " + client.socket.RemoteEndPoint + " с именем " + client.Name + "\r" + "\n");

            }

            if (text_data == "Отключение")

            {

                SendToClients("Отключение " + client.Name, client);
                textBox1.AppendText("Пользователь " + client.socket.RemoteEndPoint + "вышел из чата" + "\r" + "\n");
                client.socket.Shutdown(SocketShutdown.Both); // отключение сокета на прем и отправку сообщений
                client.socket.Close(); // закрытие соединения
                listBox1.Items.Remove(client); // удаление из списка на форме
                clients.Remove(client); // удаление из объекта список

            }

            if (text_data.StartsWith("Сообщение "))

            {

                string message = text_data.Substring(9);
                SendToClients("Сообщение от клиента " + client.Name + ": " + message, client);
                textBox2.AppendText(client.Name + ": " + message + "\r" + "\n");

            }

        }
        private void SendToClients(string command, ClientInfo exceptOf)
        {
            for (int i = 0; i < clients.Count; i++)
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
        private void SendToClients()
        {
            if (listener.Pending())
            {
                ClientInfo newClient = new ClientInfo();
                newClient.socket = listener.AcceptSocket();
                clients.Add(newClient);
                textBox1.AppendText($"Пользователь {newClient.socket.RemoteEndPoint} Подключился \r\n");
            }
        }

    }
}
