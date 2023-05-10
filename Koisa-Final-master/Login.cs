namespace WinFormsApp1
{
    public partial class Login : Form
    {
        MainForm form = new MainForm();
        Welcome form1 = new Welcome();
        public Login()
        {
            InitializeComponent();
            entpass.UseSystemPasswordChar = true;
            entlogin.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] log = File.ReadAllLines(@"C:\app\log.txt");
            string[] pass = File.ReadAllLines(@"C:\app\pass.txt");
            form1.Hide();
            int i = 0;
            int t = log.Length;
            string log1;
            string pass1;
            if (entlogin.TextLength < 2 || entpass.TextLength < 2)
            {
                MessageBox.Show("Введите значения в поля. Минимальная длина 2 символа.");
            }
            else
            {
                while (i < t)
                {
                    log1 = log[i];
                    pass1 = pass[i];
                    if (entlogin.Text == "")
                    {
                        label4.Text = "Введите логин";
                    }
                    else if (entpass.Text == "")
                    {
                        label3.Text = "Введите пароль";
                    }

                    else if (entlogin.Text != log1 & entpass.Text == pass1)
                    {
                        label3.Text = "Неверный логин";
                    }
                    else if (entlogin.Text == log1 & entpass.Text != pass1)
                    {
                        label3.Text = "Неверный пароль";
                    }
                    else if (entlogin.Text != log1 & entpass.Text != pass1)
                    {
                        label3.Text = "Неверный логин и пароль";
                    }
                    else if (entlogin.Text == log1 & entpass.Text == pass1)
                    {
                        label3.Text = "";
                        label4.Text = "";
                        MessageBox.Show("Успешный вход");
                        Hide();
                        form.Show();
                        break;
                    }
                    i++;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Welcome walcome = new Welcome();
            walcome.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                entpass.UseSystemPasswordChar = false;
            }
            else
            {
                entpass.UseSystemPasswordChar = true;
            }
        }
        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 97 || e.KeyChar >= 122) && (e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8 && number != 'A' && number != 'a' && number != 'Z' && number != 'z' && number != '_' && number != '.' && number != '-') e.Handled = true;
        }

        private void entlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entpass.Focus();
            }
        }
        private void entpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}



