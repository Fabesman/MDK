using Klient;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;

namespace Parct_19
{
    public partial class Klient : Form
    {
        Socket socket;
        private void SendToserver(string command)
        {
            byte[] date = Encoding.UTF8.GetBytes(command);
            socket.Send(date);
        }
        public Klient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(textBox1.Text, Int32.Parse(textBox2.Text));
                SendToserver("Клиент " + textBox3.Text);
                timer1.Enabled = true;
                textBox5.AppendText("Подключение к " + textBox1.Text + ": " + textBox2.Text + "\r" + "\n");
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception exp)
            {
                textBox5.AppendText(exp.Message + "\n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SendToserver("Отключение ");
                socket.Shutdown(SocketShutdown.Both); // отключение сокета для отправки и приема сообщений
                socket.Close();
                timer1.Enabled = false; // отключение таймера
                button1.Enabled = true;
                button2.Enabled = false;
                textBox5.AppendText("Отключено" + "\r" + "\n");
            }
            catch (Exception exp)
            {
                textBox5.AppendText(exp.Message + "\n");
            }
        }
        private void button3_Click(object sender, EventArgs e)// отправка сообщений
        {
            try
            {
                SendToserver("Сообщение " + textBox4.Text);
                textBox5.AppendText(textBox3.Text + ": " + textBox4.Text + "\r" + "\n");
            }
            catch (Exception exp)
            {
                textBox5.AppendText(exp.Message + "\n");
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (socket.Available > 0) // если есть новые данные
                {
                    byte[] data = new byte[socket.Available]; // создание буфера для приема сообщений
                    int data_size = socket.Receive(data); // получение данных
                    string text_data = Encoding.UTF8.GetString(data, 0, data_size);
                    if (text_data.StartsWith("Новый клиент "))
                    {
                        textBox5.AppendText(text_data.Substring(13) + " в чате" + "\r" + "\n");
                    }
                    if (text_data.StartsWith("Отключение "))
                    {
                        textBox5.AppendText(text_data.Substring(11) + " вышел из чата" + "\r" + "\n");
                    }

                    if (text_data.StartsWith("Сообщение "))
                    {
                        textBox5.AppendText(text_data.Substring(21) + "\r" + "\n");
                    }

                }
            }
            catch (Exception exp)
            {
                textBox5.AppendText(exp.Message + "\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.Show();
        }
    }
}