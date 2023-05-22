using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opa(string a)
        {
            if (label1.Text == "?")
            {
                textBox1.Text = textBox1.Text + a;
            }
            else
            {
                textBox2.Text = textBox2.Text + a;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            opa(button5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opa(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opa(button4.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (textBox1.Text != "" && Convert.ToDouble(textBox1.Text) < double.MaxValue )
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                a = 1;
            }
            if (textBox2.Text != "" && Convert.ToDouble(textBox2.Text) < double.MaxValue)
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                b = 1;
            }
            switch(label1.Text)
            {
                case "+":
                    if (a + b < double.MaxValue && a + b > double.MinValue)
                        textBox3.Text = Convert.ToString(a + b);
                    else
                        textBox3.Text = "Великое число";
                    break;
                case "-":
                    if (a - b < double.MaxValue && a - b > double.MinValue)
                        textBox3.Text = Convert.ToString(a - b);
                    else
                        textBox3.Text = "Великое число";
                    break;
                case "x":
                    if (a *b < double.MaxValue && a * b > double.MinValue)
                    textBox3.Text = Convert.ToString(a * b);
                    else
                        textBox3.Text = "Великое число";
                    break;
                case "/":
                    if (a / b < double.MaxValue && a / b > double.MinValue)
                        textBox3.Text =Convert.ToString(a/b);
                    else
                        textBox3.Text = "Великое число";
                    break;
                default:
                    textBox3.Text = textBox1.Text;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opa(button1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            opa(button6.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            opa(button10.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            opa(button9.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opa(button2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opa(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opa(button7.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            label1.Text = "?";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "x";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            int a = 1;    
            if (label1.Text == "?")
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text[i] == ',')
                        a++;
                }
                if(a < 2)
                    opa(button15.Text);
                a = 1;
            }
            else
            {
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (textBox2.Text[i] == ',')
                        a++;
                }
                if (a < 2)
                    opa(button15.Text);
                a = 1;
            }
        }
    }
}
