using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passField.UseSystemPasswordChar = true;
        }
        Form2 f2;
        Form3 f3;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass;
                string pathS = @"Players\";
                string path = Path.GetFullPath(pathS);
                StreamReader sr = new StreamReader(path + textBox1.Text + ".txt");
                pass = sr.ReadLine();
                if( pass == passField.Text)
                {
                    this.Hide();
                    f3 = new Form3();
                    f3.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            catch
            {
                MessageBox.Show("Неверное имя пользователя");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Form2();
            f2.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char ch = Convert.ToChar(textBox1.Text.Substring(i, 1));
                if (ch == ' ')
                { MessageBox.Show("Введён пробел"); textBox1.Text = null; }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passField.UseSystemPasswordChar = false;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < passField.Text.Length; i++)
            {
                char ch = Convert.ToChar(passField.Text.Substring(i, 1));
                if (ch == ' ')
                { MessageBox.Show("Введён пробел"); passField.Text = null; }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
