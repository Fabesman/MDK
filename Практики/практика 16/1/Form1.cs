﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt|Все файлы(*.*)|*.*";

        }
        
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mdiChild = new Form2();
            редактированиеToolStripMenuItem.Enabled = true;
            форматированиеToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;
            mdiChild.MdiParent = this;
            mdiChild.Show();
            int n = this.MdiChildren.Count();
            mdiChild.Text = "Документ" + Convert.ToString(n);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            редактированиеToolStripMenuItem.Enabled = true;
            форматированиеToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename, Encoding.UTF8);
            Form2 mdiChild = new Form2();
            mdiChild.MdiParent = this;
            mdiChild.Show();
            mdiChild.Text = filename;
            RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
            editBox.SelectedText = fileText;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                if (editBox != null)
                {
                    Clipboard.SetDataObject(editBox.SelectedText);
                    editBox.Cut();
                }
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                if (editBox != null)
                {
                    Clipboard.SetDataObject(editBox.SelectedText);
                }
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                if (editBox != null)
                {
                    IDataObject data = Clipboard.GetDataObject();
                    if (data.GetDataPresent(DataFormats.Text))
                    {
                        editBox.SelectedText = data.GetData(DataFormats.Text).ToString();
                    }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                if (editBox != null)
                {
                    editBox.Clear();
                }
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                editBox.Font = fontDialog1.Font;
            }  
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
            string str = editBox.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, str);
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                editBox.ForeColor = colorDialog1.Color;
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                editBox.BackColor = colorDialog1.Color;
            }
        }
    }
}
