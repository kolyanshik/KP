namespace KP
{
    partial class BuyBiletForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Exit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Место в зале:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Дата: **/**/2024";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Номер сеанса: 1";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Exit
            // 
            Exit.Location = new Point(652, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(136, 35);
            Exit.TabIndex = 3;
            Exit.Text = "Отмена";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(189, 301);
            button1.Name = "button1";
            button1.Size = new Size(130, 44);
            button1.TabIndex = 4;
            button1.Text = "Купить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BuyBiletForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Exit);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "BuyBiletForm";
            Text = "BuyBiletForm";
            Load += BuyBiletForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Exit;
        private Button button1;
    }
}