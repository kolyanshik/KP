namespace KP
{
    partial class MainForm
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
            Exit = new Button();
            History = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            Exit.Location = new Point(652, 12);
            Exit.Name = "button2";
            Exit.Size = new Size(136, 35);
            Exit.TabIndex = 1;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            History.Location = new Point(53, 340);
            History.Name = "button1";
            History.Size = new Size(175, 56);
            History.TabIndex = 2;
            History.Text = "История Сеансов";
            History.UseVisualStyleBackColor = true;
            History.Click += History_Click;
            // 
            // button3
            // 
            button3.Location = new Point(570, 340);
            button3.Name = "button3";
            button3.Size = new Size(175, 56);
            button3.TabIndex = 3;
            button3.Text = "Просмотр показов";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BuyForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(History);
            Controls.Add(Exit);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Exit;
        private Button History;
        private Button button3;
    }
}