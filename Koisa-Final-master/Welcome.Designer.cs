namespace WinFormsApp1
{
    partial class Welcome
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
            this.reg = new System.Windows.Forms.Button();
            this.vhod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.White;
            this.reg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg.Location = new System.Drawing.Point(187, 261);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(199, 50);
            this.reg.TabIndex = 0;
            this.reg.Text = "Регистрация";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // vhod
            // 
            this.vhod.BackColor = System.Drawing.Color.White;
            this.vhod.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vhod.Location = new System.Drawing.Point(449, 261);
            this.vhod.Name = "vhod";
            this.vhod.Size = new System.Drawing.Size(165, 50);
            this.vhod.TabIndex = 1;
            this.vhod.Text = "Вход";
            this.vhod.UseVisualStyleBackColor = false;
            this.vhod.Click += new System.EventHandler(this.vhod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(348, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 46.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(113, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добро пожаловать";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vhod);
            this.Controls.Add(this.reg);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button reg;
        private Button vhod;
        private Button button1;
        private Label label1;
    }
}