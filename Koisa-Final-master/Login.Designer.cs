namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            entpass = new TextBox();
            entlogin = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 76);
            label1.Name = "label1";
            label1.Size = new Size(91, 35);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 154);
            label2.Name = "label2";
            label2.Size = new Size(102, 35);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(309, 238);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // entpass
            // 
            entpass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            entpass.Location = new Point(224, 155);
            entpass.Margin = new Padding(3, 2, 3, 2);
            entpass.Name = "entpass";
            entpass.Size = new Size(189, 34);
            entpass.TabIndex = 3;
            entpass.KeyDown += entpass_KeyDown;
            entpass.KeyPress += KeyPress;
            // 
            // entlogin
            // 
            entlogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            entlogin.Location = new Point(224, 77);
            entlogin.Margin = new Padding(3, 2, 3, 2);
            entlogin.Name = "entlogin";
            entlogin.Size = new Size(189, 34);
            entlogin.TabIndex = 4;
            entlogin.KeyDown += entlogin_KeyDown;
            entlogin.KeyPress += KeyPress;
            // 
            // button2
            // 
            button2.Font = new Font("Sylfaen", 20.15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(120, 238);
            button2.Name = "button2";
            button2.Size = new Size(123, 39);
            button2.TabIndex = 6;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(441, 168);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 204);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 121);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(567, 291);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(entlogin);
            Controls.Add(entpass);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox entpass;
        private TextBox entlogin;
        private Button button2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
    }
}