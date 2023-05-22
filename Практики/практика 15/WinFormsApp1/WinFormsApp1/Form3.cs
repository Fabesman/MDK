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
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public string file = String.Empty;
        private ToolStripMenuItem практикиToolStripMenuItem;
        private ToolStripMenuItem практика1ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem;
        private ToolStripMenuItem запускToolStripMenuItem;
        private ToolStripMenuItem практика2ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem1;
        private ToolStripMenuItem запускToolStripMenuItem1;
        private ToolStripMenuItem практика3ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem2;
        private ToolStripMenuItem запускToolStripMenuItem2;
        private ToolStripMenuItem практика4ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem3;
        private ToolStripMenuItem запускToolStripMenuItem3;
        private ToolStripMenuItem практика5ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem4;
        private ToolStripMenuItem запускToolStripMenuItem4;
        private ToolStripMenuItem практика6ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem5;
        private ToolStripMenuItem запускToolStripMenuItem5;
        private ToolStripMenuItem практика7ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem6;
        private ToolStripMenuItem запускToolStripMenuItem6;
        private ToolStripMenuItem практика8ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem7;
        private ToolStripMenuItem запускToolStripMenuItem7;
        private ToolStripMenuItem практика9ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem8;
        private ToolStripMenuItem запускToolStripMenuItem8;
        private ToolStripMenuItem практика10ToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem9;
        private ToolStripMenuItem запускToolStripMenuItem9;
        private ToolStripMenuItem праквкаToolStripMenuItem;
        private ToolStripMenuItem инфоToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem отменаToolStripMenuItem;
        private ToolStripMenuItem аккаунтToolStripMenuItem;
        private ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private ToolStripMenuItem завершитьРаботуToolStripMenuItem;
        private ToolStripMenuItem задание1ToolStripMenuItem;
        private ToolStripMenuItem задание2ToolStripMenuItem;
        private ToolStripMenuItem задание3ToolStripMenuItem;
        private ToolStripMenuItem задание1ToolStripMenuItem1;
        private ToolStripMenuItem задание2ToolStripMenuItem1;
        private ToolStripMenuItem задание3ToolStripMenuItem1;
        private TextBox textBox1;
        private ToolStripMenuItem задание1ToolStripMenuItem2;
        private ToolStripMenuItem задание2ToolStripMenuItem2;
        private ToolStripMenuItem задание1ToolStripMenuItem3;
        private ToolStripMenuItem задание2ToolStripMenuItem3;
        private ToolStripMenuItem задание2ToolStripMenuItem4;
        private ToolStripMenuItem задание1ToolStripMenuItem4;
        private ToolStripMenuItem задание1ToolStripMenuItem5;
        private ToolStripMenuItem задание3ToolStripMenuItem2;
        private ToolStripMenuItem задание4ToolStripMenuItem;
        private ToolStripMenuItem задание1ToolStripMenuItem6;
        private ToolStripMenuItem задание2ToolStripMenuItem5;
        private ToolStripMenuItem задание3ToolStripMenuItem3;
        private ToolStripMenuItem задание4ToolStripMenuItem1;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem задание1ToolStripMenuItem7;
        private ToolStripMenuItem задание2ToolStripMenuItem6;
        private ToolStripMenuItem задание3ToolStripMenuItem4;
        private ToolStripMenuItem задание1ToolStripMenuItem8;
        private ToolStripMenuItem задание2ToolStripMenuItem7;
        private ToolStripMenuItem задание3ToolStripMenuItem5;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private MenuStrip menuStrip1;

        public Form3()
        {
            InitializeComponent();
            
        }
        Form1 f1;
        

        private void InitializeComponent()
        {
            
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.практикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практика1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практика2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.практика10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.праквкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.практикиToolStripMenuItem,
            this.праквкаToolStripMenuItem,
            this.инфоToolStripMenuItem,
            this.аккаунтToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // практикиToolStripMenuItem
            // 
            this.практикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.практика1ToolStripMenuItem,
            this.практика2ToolStripMenuItem,
            this.практика3ToolStripMenuItem,
            this.практика4ToolStripMenuItem,
            this.практика5ToolStripMenuItem,
            this.практика6ToolStripMenuItem,
            this.практика7ToolStripMenuItem,
            this.практика8ToolStripMenuItem,
            this.практика9ToolStripMenuItem,
            this.практика10ToolStripMenuItem});
            this.практикиToolStripMenuItem.Name = "практикиToolStripMenuItem";
            this.практикиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.практикиToolStripMenuItem.Text = "Практики";
            // 
            // практика1ToolStripMenuItem
            // 
            this.практика1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem,
            this.запускToolStripMenuItem});
            this.практика1ToolStripMenuItem.Name = "практика1ToolStripMenuItem";
            this.практика1ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика1ToolStripMenuItem.Text = "Практика 1";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // запускToolStripMenuItem
            // 
            this.запускToolStripMenuItem.Name = "запускToolStripMenuItem";
            this.запускToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem.Text = "Запуск";
            // 
            // практика2ToolStripMenuItem
            // 
            this.практика2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem1,
            this.запускToolStripMenuItem1});
            this.практика2ToolStripMenuItem.Name = "практика2ToolStripMenuItem";
            this.практика2ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика2ToolStripMenuItem.Text = "Практика 2";
            // 
            // просмотрToolStripMenuItem1
            // 
            this.просмотрToolStripMenuItem1.Name = "просмотрToolStripMenuItem1";
            this.просмотрToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem1.Text = "Просмотр";
            // 
            // запускToolStripMenuItem1
            // 
            this.запускToolStripMenuItem1.Name = "запускToolStripMenuItem1";
            this.запускToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem1.Text = "Запуск";
            // 
            // практика3ToolStripMenuItem
            // 
            this.практика3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem2,
            this.запускToolStripMenuItem2});
            this.практика3ToolStripMenuItem.Name = "практика3ToolStripMenuItem";
            this.практика3ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика3ToolStripMenuItem.Text = "Практика 3";
            // 
            // просмотрToolStripMenuItem2
            // 
            this.просмотрToolStripMenuItem2.Name = "просмотрToolStripMenuItem2";
            this.просмотрToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem2.Text = "Просмотр";
            // 
            // запускToolStripMenuItem2
            // 
            this.запускToolStripMenuItem2.Name = "запускToolStripMenuItem2";
            this.запускToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem2.Text = "Запуск";
            // 
            // практика4ToolStripMenuItem
            // 
            this.практика4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem3,
            this.запускToolStripMenuItem3});
            this.практика4ToolStripMenuItem.Name = "практика4ToolStripMenuItem";
            this.практика4ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика4ToolStripMenuItem.Text = "Практика 4";
            // 
            // просмотрToolStripMenuItem3
            // 
            this.просмотрToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem,
            this.задание2ToolStripMenuItem,
            this.задание3ToolStripMenuItem});
            this.просмотрToolStripMenuItem3.Name = "просмотрToolStripMenuItem3";
            this.просмотрToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem3.Text = "Просмотр";
            // 
            // задание1ToolStripMenuItem
            // 
            this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem.Text = "Задание 1";
            this.задание1ToolStripMenuItem.Click += new System.EventHandler(this.задание1ToolStripMenuItem_Click);
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem.Text = "Задание 2";
            this.задание2ToolStripMenuItem.Click += new System.EventHandler(this.задание2ToolStripMenuItem_Click);
            // 
            // задание3ToolStripMenuItem
            // 
            this.задание3ToolStripMenuItem.Name = "задание3ToolStripMenuItem";
            this.задание3ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.задание3ToolStripMenuItem.Text = "Задание 3";
            this.задание3ToolStripMenuItem.Click += new System.EventHandler(this.задание3ToolStripMenuItem_Click);
            // 
            // запускToolStripMenuItem3
            // 
            this.запускToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem1,
            this.задание2ToolStripMenuItem1,
            this.задание3ToolStripMenuItem1});
            this.запускToolStripMenuItem3.Name = "запускToolStripMenuItem3";
            this.запускToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem3.Text = "Запуск";
            // 
            // задание1ToolStripMenuItem1
            // 
            this.задание1ToolStripMenuItem1.Name = "задание1ToolStripMenuItem1";
            this.задание1ToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem1.Text = "Задание 1";
            this.задание1ToolStripMenuItem1.Click += new System.EventHandler(this.задание1ToolStripMenuItem1_Click);
            // 
            // задание2ToolStripMenuItem1
            // 
            this.задание2ToolStripMenuItem1.Name = "задание2ToolStripMenuItem1";
            this.задание2ToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem1.Text = "Задание 2";
            // 
            // задание3ToolStripMenuItem1
            // 
            this.задание3ToolStripMenuItem1.Name = "задание3ToolStripMenuItem1";
            this.задание3ToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.задание3ToolStripMenuItem1.Text = "Задание 3";
            // 
            // практика5ToolStripMenuItem
            // 
            this.практика5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem4,
            this.запускToolStripMenuItem4});
            this.практика5ToolStripMenuItem.Name = "практика5ToolStripMenuItem";
            this.практика5ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика5ToolStripMenuItem.Text = "Практика 5";
            // 
            // просмотрToolStripMenuItem4
            // 
            this.просмотрToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem2,
            this.задание2ToolStripMenuItem2,
            this.задание2ToolStripMenuItem4});
            this.просмотрToolStripMenuItem4.Name = "просмотрToolStripMenuItem4";
            this.просмотрToolStripMenuItem4.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem4.Text = "Просмотр";
            // 
            // задание1ToolStripMenuItem2
            // 
            this.задание1ToolStripMenuItem2.Name = "задание1ToolStripMenuItem2";
            this.задание1ToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem2.Text = "Задание 1";
            this.задание1ToolStripMenuItem2.Click += new System.EventHandler(this.задание1ToolStripMenuItem2_Click);
            // 
            // задание2ToolStripMenuItem2
            // 
            this.задание2ToolStripMenuItem2.Name = "задание2ToolStripMenuItem2";
            this.задание2ToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem2.Text = "Задание 2";
            this.задание2ToolStripMenuItem2.Click += new System.EventHandler(this.задание2ToolStripMenuItem2_Click);
            // 
            // задание2ToolStripMenuItem4
            // 
            this.задание2ToolStripMenuItem4.Name = "задание2ToolStripMenuItem4";
            this.задание2ToolStripMenuItem4.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem4.Text = "Задание 2";
            // 
            // запускToolStripMenuItem4
            // 
            this.запускToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem3,
            this.задание2ToolStripMenuItem3});
            this.запускToolStripMenuItem4.Name = "запускToolStripMenuItem4";
            this.запускToolStripMenuItem4.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem4.Text = "Запуск";
            // 
            // задание1ToolStripMenuItem3
            // 
            this.задание1ToolStripMenuItem3.Name = "задание1ToolStripMenuItem3";
            this.задание1ToolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem3.Text = "Задание 1";
            // 
            // задание2ToolStripMenuItem3
            // 
            this.задание2ToolStripMenuItem3.Name = "задание2ToolStripMenuItem3";
            this.задание2ToolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem3.Text = "Задание 2";
            // 
            // практика6ToolStripMenuItem
            // 
            this.практика6ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem5,
            this.запускToolStripMenuItem5});
            this.практика6ToolStripMenuItem.Name = "практика6ToolStripMenuItem";
            this.практика6ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика6ToolStripMenuItem.Text = "Практика 6";
            // 
            // просмотрToolStripMenuItem5
            // 
            this.просмотрToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem4,
            this.задание1ToolStripMenuItem5,
            this.задание3ToolStripMenuItem2,
            this.задание4ToolStripMenuItem});
            this.просмотрToolStripMenuItem5.Name = "просмотрToolStripMenuItem5";
            this.просмотрToolStripMenuItem5.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem5.Text = "Просмотр";
            // 
            // задание1ToolStripMenuItem4
            // 
            this.задание1ToolStripMenuItem4.Name = "задание1ToolStripMenuItem4";
            this.задание1ToolStripMenuItem4.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem4.Text = "Задание 1";
            this.задание1ToolStripMenuItem4.Click += new System.EventHandler(this.задание1ToolStripMenuItem4_Click);
            // 
            // задание1ToolStripMenuItem5
            // 
            this.задание1ToolStripMenuItem5.Name = "задание1ToolStripMenuItem5";
            this.задание1ToolStripMenuItem5.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem5.Text = "Задание 2";
            this.задание1ToolStripMenuItem5.Click += new System.EventHandler(this.задание1ToolStripMenuItem5_Click);
            // 
            // задание3ToolStripMenuItem2
            // 
            this.задание3ToolStripMenuItem2.Name = "задание3ToolStripMenuItem2";
            this.задание3ToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.задание3ToolStripMenuItem2.Text = "Задание 3";
            this.задание3ToolStripMenuItem2.Click += new System.EventHandler(this.задание3ToolStripMenuItem2_Click);
            // 
            // задание4ToolStripMenuItem
            // 
            this.задание4ToolStripMenuItem.Name = "задание4ToolStripMenuItem";
            this.задание4ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.задание4ToolStripMenuItem.Text = "Задание 4";
            this.задание4ToolStripMenuItem.Click += new System.EventHandler(this.задание4ToolStripMenuItem_Click);
            // 
            // запускToolStripMenuItem5
            // 
            this.запускToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem6,
            this.задание2ToolStripMenuItem5,
            this.задание3ToolStripMenuItem3,
            this.задание4ToolStripMenuItem1});
            this.запускToolStripMenuItem5.Name = "запускToolStripMenuItem5";
            this.запускToolStripMenuItem5.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem5.Text = "Запуск";
            // 
            // задание1ToolStripMenuItem6
            // 
            this.задание1ToolStripMenuItem6.Name = "задание1ToolStripMenuItem6";
            this.задание1ToolStripMenuItem6.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem6.Text = "Задание 1";
            // 
            // задание2ToolStripMenuItem5
            // 
            this.задание2ToolStripMenuItem5.Name = "задание2ToolStripMenuItem5";
            this.задание2ToolStripMenuItem5.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem5.Text = "Задание 2";
            // 
            // задание3ToolStripMenuItem3
            // 
            this.задание3ToolStripMenuItem3.Name = "задание3ToolStripMenuItem3";
            this.задание3ToolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.задание3ToolStripMenuItem3.Text = "Задание 3";
            // 
            // задание4ToolStripMenuItem1
            // 
            this.задание4ToolStripMenuItem1.Name = "задание4ToolStripMenuItem1";
            this.задание4ToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.задание4ToolStripMenuItem1.Text = "Задание 4";
            // 
            // практика7ToolStripMenuItem
            // 
            this.практика7ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem6,
            this.запускToolStripMenuItem6});
            this.практика7ToolStripMenuItem.Name = "практика7ToolStripMenuItem";
            this.практика7ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика7ToolStripMenuItem.Text = "Практика 7";
            this.практика7ToolStripMenuItem.Click += new System.EventHandler(this.практика7ToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem6
            // 
            this.просмотрToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem7,
            this.задание2ToolStripMenuItem6,
            this.задание3ToolStripMenuItem4});
            this.просмотрToolStripMenuItem6.Name = "просмотрToolStripMenuItem6";
            this.просмотрToolStripMenuItem6.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem6.Text = "Просмотр";
            // 
            // задание1ToolStripMenuItem7
            // 
            this.задание1ToolStripMenuItem7.Name = "задание1ToolStripMenuItem7";
            this.задание1ToolStripMenuItem7.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem7.Text = "Задание 1";
            this.задание1ToolStripMenuItem7.Click += new System.EventHandler(this.задание1ToolStripMenuItem7_Click);
            // 
            // задание2ToolStripMenuItem6
            // 
            this.задание2ToolStripMenuItem6.Name = "задание2ToolStripMenuItem6";
            this.задание2ToolStripMenuItem6.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem6.Text = "Задание 2";
            this.задание2ToolStripMenuItem6.Click += new System.EventHandler(this.задание2ToolStripMenuItem6_Click);
            // 
            // задание3ToolStripMenuItem4
            // 
            this.задание3ToolStripMenuItem4.Name = "задание3ToolStripMenuItem4";
            this.задание3ToolStripMenuItem4.Size = new System.Drawing.Size(128, 22);
            this.задание3ToolStripMenuItem4.Text = "Задание 3";
            this.задание3ToolStripMenuItem4.Click += new System.EventHandler(this.задание3ToolStripMenuItem4_Click);
            // 
            // запускToolStripMenuItem6
            // 
            this.запускToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem8,
            this.задание2ToolStripMenuItem7,
            this.задание3ToolStripMenuItem5});
            this.запускToolStripMenuItem6.Name = "запускToolStripMenuItem6";
            this.запускToolStripMenuItem6.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem6.Text = "Запуск";
            // 
            // задание1ToolStripMenuItem8
            // 
            this.задание1ToolStripMenuItem8.Name = "задание1ToolStripMenuItem8";
            this.задание1ToolStripMenuItem8.Size = new System.Drawing.Size(128, 22);
            this.задание1ToolStripMenuItem8.Text = "Задание 1";
            // 
            // задание2ToolStripMenuItem7
            // 
            this.задание2ToolStripMenuItem7.Name = "задание2ToolStripMenuItem7";
            this.задание2ToolStripMenuItem7.Size = new System.Drawing.Size(128, 22);
            this.задание2ToolStripMenuItem7.Text = "Задание 2";
            // 
            // задание3ToolStripMenuItem5
            // 
            this.задание3ToolStripMenuItem5.Name = "задание3ToolStripMenuItem5";
            this.задание3ToolStripMenuItem5.Size = new System.Drawing.Size(128, 22);
            this.задание3ToolStripMenuItem5.Text = "Задание 3";
            // 
            // практика8ToolStripMenuItem
            // 
            this.практика8ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem7,
            this.запускToolStripMenuItem7});
            this.практика8ToolStripMenuItem.Name = "практика8ToolStripMenuItem";
            this.практика8ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика8ToolStripMenuItem.Text = "Практика 8";
            // 
            // просмотрToolStripMenuItem7
            // 
            this.просмотрToolStripMenuItem7.Name = "просмотрToolStripMenuItem7";
            this.просмотрToolStripMenuItem7.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem7.Text = "Просмотр";
            // 
            // запускToolStripMenuItem7
            // 
            this.запускToolStripMenuItem7.Name = "запускToolStripMenuItem7";
            this.запускToolStripMenuItem7.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem7.Text = "Запуск";
            // 
            // практика9ToolStripMenuItem
            // 
            this.практика9ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem8,
            this.запускToolStripMenuItem8});
            this.практика9ToolStripMenuItem.Name = "практика9ToolStripMenuItem";
            this.практика9ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика9ToolStripMenuItem.Text = "Практика 9";
            // 
            // просмотрToolStripMenuItem8
            // 
            this.просмотрToolStripMenuItem8.Name = "просмотрToolStripMenuItem8";
            this.просмотрToolStripMenuItem8.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem8.Text = "Просмотр";
            // 
            // запускToolStripMenuItem8
            // 
            this.запускToolStripMenuItem8.Name = "запускToolStripMenuItem8";
            this.запускToolStripMenuItem8.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem8.Text = "Запуск";
            // 
            // практика10ToolStripMenuItem
            // 
            this.практика10ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem9,
            this.запускToolStripMenuItem9});
            this.практика10ToolStripMenuItem.Name = "практика10ToolStripMenuItem";
            this.практика10ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.практика10ToolStripMenuItem.Text = "Практика 10";
            // 
            // просмотрToolStripMenuItem9
            // 
            this.просмотрToolStripMenuItem9.Name = "просмотрToolStripMenuItem9";
            this.просмотрToolStripMenuItem9.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem9.Text = "Просмотр";
            // 
            // запускToolStripMenuItem9
            // 
            this.запускToolStripMenuItem9.Name = "запускToolStripMenuItem9";
            this.запускToolStripMenuItem9.Size = new System.Drawing.Size(131, 22);
            this.запускToolStripMenuItem9.Text = "Запуск";
            // 
            // праквкаToolStripMenuItem
            // 
            this.праквкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.отменаToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.праквкаToolStripMenuItem.Name = "праквкаToolStripMenuItem";
            this.праквкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.праквкаToolStripMenuItem.Text = "Правка";
            this.праквкаToolStripMenuItem.Click += new System.EventHandler(this.праквкаToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.отменаToolStripMenuItem.Text = "Отменить";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            this.инфоToolStripMenuItem.Click += new System.EventHandler(this.инфоToolStripMenuItem_Click);
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзАккаунтаToolStripMenuItem,
            this.завершитьРаботуToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.аккаунтToolStripMenuItem.Text = "Меню";
            this.аккаунтToolStripMenuItem.Click += new System.EventHandler(this.аккаунтToolStripMenuItem_Click);
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            this.выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            this.выйтиИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            this.выйтиИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзАккаунтаToolStripMenuItem_Click);
            // 
            // завершитьРаботуToolStripMenuItem
            // 
            this.завершитьРаботуToolStripMenuItem.Name = "завершитьРаботуToolStripMenuItem";
            this.завершитьРаботуToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.завершитьРаботуToolStripMenuItem.Text = "Завершить работу";
            this.завершитьРаботуToolStripMenuItem.Click += new System.EventHandler(this.завершитьРаботуToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1458, 805);
            this.textBox1.TabIndex = 1;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 1300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void завершитьРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new Form1();
            f1.Show();
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана по заказу Кс54\n ООО Дьявол😈 может🦾 кодить💻");
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P4.1";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P4.2";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P4.3";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P5.1";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P5.2";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание1ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P6.2";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P6.1";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P6.3";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P6.4";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void праквкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void практика7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void задание1ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P7.1";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }

        private void задание2ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P7.2";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }
        /// 
        /// 
        ///  запуск txt
        /// 
        /// 
        private void задание3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string pathS = @"Code\P7.3";
            string path = Path.GetFullPath(pathS);
            StreamReader sr = new StreamReader(path + ".txt");
            textBox1.Text = sr.ReadToEnd();
        }
        /// 
        /// 
        ///  запуск exe
        /// 
        /// 
        private void задание1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string pathS = @"Proga\P4.1\ConsoleApp1";
            string path = Path.GetFullPath(pathS);
            Process.Start(path + ".exe");
        }
        
        Form4 f4; 
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
            f4 = new Form4();
            this.Hide();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd1.FileName).ToUpper().ToLower().Equals(".txt", StringComparison.CurrentCultureIgnoreCase))
                { textBox1.Text = File.ReadAllText(ofd1.FileName);
                    file = Path.GetFullPath(ofd1.FileName);
                }
            }
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            file = null;
        }
    }
}
