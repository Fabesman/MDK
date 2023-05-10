namespace WinFormsApp1
{
    public partial class Welcome : Form
    {
        public Welcome()
        { 
            InitializeComponent();
        }
        private void vhod_Click(object sender, EventArgs e)
        {
            Login ex = new Login();
            this.Hide();
            ex.Show();
        }
        private void reg_Click(object sender, EventArgs e)
        {
            Registration registration= new Registration();
            registration.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
