namespace WinFormsApp1
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            enter_auto = new Button();
            password1 = new TextBox();
            User = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lable4 = new Label();
            password2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // enter_auto
            // 
            enter_auto.BackColor = Color.Gold;
            resources.ApplyResources(enter_auto, "enter_auto");
            enter_auto.ForeColor = SystemColors.ActiveCaptionText;
            enter_auto.Name = "enter_auto";
            enter_auto.UseVisualStyleBackColor = false;
            enter_auto.Click += enter_auto_Click;
            // 
            // password1
            // 
            resources.ApplyResources(password1, "password1");
            password1.Name = "password1";
            password1.KeyDown += password1_KeyDown;
            password1.KeyPress += KeyPress;
            // 
            // User
            // 
            resources.ApplyResources(User, "User");
            User.Name = "User";
            User.KeyPress += KeyPress;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lable4
            // 
            resources.ApplyResources(lable4, "lable4");
            lable4.Name = "lable4";
            // 
            // password2
            // 
            resources.ApplyResources(password2, "password2");
            password2.Name = "password2";
            password2.KeyDown += password2_KeyDown;
            password2.KeyPress += KeyPress;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registration
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(password2);
            Controls.Add(lable4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(User);
            Controls.Add(password1);
            Controls.Add(enter_auto);
            MinimizeBox = false;
            Name = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enter_auto;
        private TextBox password1;
        private TextBox User;

        private Label label2;
        private Label label1;
        private Label lable4;
        private TextBox password2;
        private Label label3;
        private Button button1;
    }
}