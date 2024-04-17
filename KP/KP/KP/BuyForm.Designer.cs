using System.Resources;

namespace KP
{
    partial class BuyForm
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
            Yopiter = new Button();
            Mars = new Button();
            Satyrn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(652, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(136, 35);
            Exit.TabIndex = 2;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Yopiter
            // 
            Yopiter.Location = new Point(321, 292);
            Yopiter.Name = "Yopiter";
            Yopiter.Size = new Size(134, 49);
            Yopiter.TabIndex = 3;
            Yopiter.Text = "Юпитер";
            Yopiter.UseVisualStyleBackColor = true;
            Yopiter.Click += Yopiter_Click;
            // 
            // Mars
            // 
            Mars.Location = new Point(77, 292);
            Mars.Name = "Mars";
            Mars.Size = new Size(134, 49);
            Mars.TabIndex = 4;
            Mars.Text = "Марс";
            Mars.UseVisualStyleBackColor = true;
            Mars.Click += Mars_Click;
            // 
            // Satyrn
            // 
            Satyrn.Location = new Point(559, 292);
            Satyrn.Name = "Satyrn";
            Satyrn.Size = new Size(134, 49);
            Satyrn.TabIndex = 5;
            Satyrn.Text = "Сатурн";
            Satyrn.UseVisualStyleBackColor = true;
            Satyrn.Click += Satyrn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "              Цена 999р";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "              Цена 999р";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(559, 347);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 9;
            textBox3.Text = "              Цена 999р";
            // 
            // BuyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Satyrn);
            Controls.Add(Mars);
            Controls.Add(Yopiter);
            Controls.Add(Exit);
            Name = "BuyForm";
            Text = "BuyForm";
            Load += BuyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button Yopiter;
        private Button Mars;
        private Button Satyrn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}