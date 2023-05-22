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
    public partial class Form2 : Form
    {
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        Form1 f1;
        private Label label4;
        private Button button3;
        private static int Pasha = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 23);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя пользователя:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 23);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Повторите пароль:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Регистрация";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 700);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            switch(Pasha)
            {
                case 0:
                    MessageBox.Show("Повторите пароль");
                    Pasha++;
                    break;
                case 1:
                    MessageBox.Show("Повторите пароль");
                    Pasha++;
                    break;
                case 2:
                    MessageBox.Show("Повторите пароль... Пожалуйста.");
                    Pasha++;
                    break;
                case 3:
                    MessageBox.Show("Повторите пароль, пожалуйста!");
                    Pasha++;
                    break;
                case 4:
                    MessageBox.Show("Повторите пароль!");
                    Pasha++;
                    break;
                case 5:
                    MessageBox.Show("Я сказал, повторите пароль!!!");
                    Pasha++;
                    break;
                case 6:
                    MessageBox.Show("...");
                    Pasha++;
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                char ch = Convert.ToChar(textBox3.Text.Substring(i, 1));
                if (ch == ' ')
                { MessageBox.Show("Введён пробел"); textBox3.Text = null; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new Form1();
            f1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathS = @"Players\";
            string path = Path.GetFullPath(pathS);
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else
            if(textBox2.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }
            else
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите имя пользователя");
            }
            else
            try
            {
                StreamReader sr = new StreamReader(path + textBox1.Text + ".txt");
                MessageBox.Show("Это имя занято");
            }
            catch
            {
                using (FileStream FS = File.Open(path + textBox1.Text + ".txt",FileMode.Create))
                {
                    using (StreamWriter output = new StreamWriter(FS))
                    {
                        output.Write(textBox2.Text);
                    }
                }
                this.Hide();
                f1 = new Form1();
                f1.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                char ch = Convert.ToChar(textBox2.Text.Substring(i, 1));
                if (ch == ' ')
                { MessageBox.Show("Введён пробел"); textBox2.Text = null; }
            }
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
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
