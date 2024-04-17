namespace KP
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button1 = new Button();
            button2 = new Button();
            txtUsername = new RichTextBox();
            txtPassword = new RichTextBox();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(661, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(136, 35);
            Button1.TabIndex = 0;
            Button1.Text = "Регистрация";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += btnRegister_Click;
            // 
            // button2
            // 
            button2.Location = new Point(360, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Вход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(255, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(295, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(255, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Button1;
        private Button button2;
        private RichTextBox txtUsername;
        private RichTextBox txtPassword;
    }
}