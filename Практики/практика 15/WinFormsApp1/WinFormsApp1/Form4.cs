using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Form4 f4;
        Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            string pathS = @"Project\";
            string path = Path.GetFullPath(pathS);
            MessageBox.Show(path);
                try
                {
                    StreamReader sr = new StreamReader(path + textBox1.Text + ".txt");
                    MessageBox.Show("Это имя занято");
                }
                catch
                {
                    using (FileStream FS = File.Open(path + textBox1.Text + ".txt", FileMode.Create))
                    {
                    }
                string file = path + textBox1.Text + ".txt";
                f4 = new Form1();
                   
                f4.Show();
                    this.Hide();
                }
        }
    }
}
