using System.IO;
namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Tex.Hide();

        }
        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Copy();
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Paste();
        }
        private void наНаачальныйЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Hide();
        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Cut();
        }
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Undo();
        }
        //Практическая №2
        private void посмотретьКодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\2\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\2\1\1.exe";
            Go.Start();
        }
        private void запуститьПрограмму2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\2\2\2.exe";
            Go.Start();
        }
        //Практическая №3
        private void посмотретьКод1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\3\1.txt");
        }
        private void посмотретьКод2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\3\2.txt");
        }
        private void запуститьПрограмму1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\3\1\1.exe";
            Go.Start();
        }
        private void запуститьПрограмму2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\3\2\2.exe";
            Go.Start();
        }
        //Практическая №4
        private void посмотретьКод1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\4\1.txt");
        }
        private void посмотретьКод2ToolStripMenuItem1_Click(object sender, EventArgs e)//4.2
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\4\2.txt");
        }
        private void запуститьПрограмму1ToolStripMenuItem1_Click(object sender, EventArgs e)//4.1
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\4\1\1.exe";
            Go.Start();
        }
        private void запуститьПрограмму2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\4\2\2.exe";
            Go.Start();
        }
        //Практическая №5
        private void посмотретьКод12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\5\1-2.txt");
        }
        private void запуститьПрограмму12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\5\1-2.exe";
            Go.Start();
        }
        //Практическая №6
        private void плсмотретьКодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\6\1.txt");
        }
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\6\1.exe";
            Go.Start();
        }
        //Практическая №7
        private void запуститьКодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\7\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\7\1.exe";
            Go.Start();
        }
        //Практическая №8
        private void запуститьКодToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\8\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\8\1.exe";
            Go.Start();
        }
        //Практическая №9
        private void запуститьКодToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\9\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\9\1.exe";
            Go.Start();
        }
        //Практическая №10
        private void запуститьКодToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\10\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\10\1.exe";
            Go.Start();
        }
        //Практическая №11
        private void запуститьКодToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\11\1.exe";
            Go.Start();
        }
        private void запуститьПрограммуToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\11\1.txt");
        }
        //Практическая №12
        private void запуститьКодToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\12\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\12\1.exe";
            Go.Start();
        }
        //Практическая №13
        private void запуститьКодToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\13\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\13\1.exe";
            Go.Start();
        }
        //Практическая №14
        private void запуститьКодToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\14\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\14\1.exe";
            Go.Start();
        }
        //Практическая №15
        private void запуститьКодToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\15\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\15\1.exe";
            Go.Start();
        }
        //Практическая №16
        private void запуститьКодToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\16\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\16\1.exe";
            Go.Start();
        }
        //Практическая №17
        private void запуститьКодToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\17\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\17\1.exe";
            Go.Start();
        }
        //Практическая №18
        private void запуститьКодToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\18\1.txt");
        }
        private void запуститьПрограммуToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\18\1.exe";
            Go.Start();
        }
        //Практическая №18
        private void посмотретьКодToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\19\1.txt");
        }

        private void запуститьПрограммуToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\19\1.exe";
            Go.Start();
        }
    }
}