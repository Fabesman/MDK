namespace WinFormsApp1
{
    public partial class Registration : Form
    {
        Welcome wel = new Welcome();
        public Registration()
        {
            InitializeComponent();
            User.Focus();
        }
        private void enter_auto_Click(object sender, EventArgs e)
        {
            if (User.TextLength < 2 || password2.TextLength < 2 || password1.TextLength < 2)
            {
                MessageBox.Show("Введите значения в поля. Минимальная длина 2 символа.");
            }
            else
            {
                string pathS = @"C:\app\log.txt";
                string path = Path.GetFullPath(pathS);
                string path1 = @"C:\app\pass.txt";
                string path2 = Path.GetFullPath(path1);

                if (password1.Text == password2.Text && password1.Text != "" && password2.Text != "")
                {
                    try
                    {
                        File.AppendAllText(path, User.Text + "\n");
                        File.AppendAllText(path2, password1.Text + "\n");
                    }
                    catch
                    {
                        File.Create("log.txt");
                        File.Create("pass.txt");
                        File.AppendAllText(path, User.Text + "\n");
                        File.AppendAllText(path2, password1.Text + "\n");
                    }
                    this.Hide();
                    MessageBox.Show("Регистрация успешна");
                    wel.Show();
                }
                else
                {
                    label3.Text = "Пароли не совпадают";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Welcome walcome = new Welcome();
            walcome.Show();
            this.Hide();
        }
        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 97 || e.KeyChar >= 122) && (e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8&& number!='A' && number != 'a' && number != 'Z' && number != 'z' && number!='_'&& number!='.'&& number!='-') e.Handled = true;
        }
        private void password1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password1.Focus();
            }
        }
        private void password2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password2.Focus();
            }
        }
    }
}
