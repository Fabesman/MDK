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
        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Copy();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Paste();
        }
        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Hide();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Cut();
        }
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Undo();
        }
        //������������ �2
        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\2\1.txt");
        }
        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\2\1\1.exe";
            Go.Start();
        }
        private void ������������������2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\2\2\2.exe";
            Go.Start();
        }
        //������������ �3
        private void �������������1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\3\1.txt");
        }
        private void �������������2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\3\2.txt");
        }
        private void ������������������1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\3\1\1.exe";
            Go.Start();
        }
        private void ������������������2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\3\2\2.exe";
            Go.Start();
        }
        //������������ �4
        private void �������������1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\4\1.txt");
        }
        private void �������������2ToolStripMenuItem1_Click(object sender, EventArgs e)//4.2
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\4\2.txt");
        }
        private void ������������������1ToolStripMenuItem1_Click(object sender, EventArgs e)//4.1
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\4\1\1.exe";
            Go.Start();
        }
        private void ������������������2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\4\2\2.exe";
            Go.Start();
        }
        //������������ �5
        private void �������������12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\5\1-2.txt");
        }
        private void ������������������12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\5\1-2.exe";
            Go.Start();
        }
        //������������ �6
        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\6\1.txt");
        }
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\6\1.exe";
            Go.Start();
        }
        //������������ �7
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\7\1.txt");
        }
        private void ������������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\7\1.exe";
            Go.Start();
        }
        //������������ �8
        private void ������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\8\1.txt");
        }
        private void ������������������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\8\1.exe";
            Go.Start();
        }
        //������������ �9
        private void ������������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\9\1.txt");
        }
        private void ������������������ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\9\1.exe";
            Go.Start();
        }
        //������������ �10
        private void ������������ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\10\1.txt");
        }
        private void ������������������ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\10\1.exe";
            Go.Start();
        }
        //������������ �11
        private void ������������ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\11\1.exe";
            Go.Start();
        }
        private void ������������������ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\11\1.txt");
        }
        //������������ �12
        private void ������������ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\12\1.txt");
        }
        private void ������������������ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\12\1.exe";
            Go.Start();
        }
        //������������ �13
        private void ������������ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\13\1.txt");
        }
        private void ������������������ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\13\1.exe";
            Go.Start();
        }
        //������������ �14
        private void ������������ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\14\1.txt");
        }
        private void ������������������ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\14\1.exe";
            Go.Start();
        }
        //������������ �15
        private void ������������ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\15\1.txt");
        }
        private void ������������������ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\15\1.exe";
            Go.Start();
        }
        //������������ �16
        private void ������������ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\16\1.txt");
        }
        private void ������������������ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\16\1.exe";
            Go.Start();
        }
        //������������ �17
        private void ������������ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\17\1.txt");
        }
        private void ������������������ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\17\1.exe";
            Go.Start();
        }
        //������������ �18
        private void ������������ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\18\1.txt");
        }
        private void ������������������ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\18\1.exe";
            Go.Start();
        }
        //������������ �18
        private void �������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tex.Show();
            Tex.Text = File.ReadAllText(@"C:\app\Code\19\1.txt");
        }

        private void ������������������ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Go = new System.Diagnostics.Process();
            Go.StartInfo.FileName = @"C:\app\Exe\19\1.exe";
            Go.Start();
        }
    }
}