namespace OOPFinalProrect
{
    partial class SignUp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            mainPanel = new Panel();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 123, 255);
            label1.Location = new Point(150, 40);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 0;
            label1.Text = "Sign up";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(50, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(50, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 29);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(108, 117, 125);
            label2.Location = new Point(50, 180);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 3;
            label2.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(108, 117, 125);
            label3.Location = new Point(50, 100);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 4;
            label3.Text = "Full Name:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(50, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(50, 360);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 29);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(108, 117, 125);
            label4.Location = new Point(50, 260);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 7;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(108, 117, 125);
            label5.Location = new Point(50, 340);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 8;
            label5.Text = "Confirm Password:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 123, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(50, 420);
            button1.Name = "button1";
            button1.Size = new Size(300, 50);
            button1.TabIndex = 9;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 123, 255);
            button2.Location = new Point(160, 480);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 10;
            button2.Text = "or sign in";
            button2.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(45, 45, 48);
            mainPanel.Controls.Add(button2);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(label5);
            mainPanel.Controls.Add(label4);
            mainPanel.Controls.Add(textBox4);
            mainPanel.Controls.Add(textBox3);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(textBox2);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(200, 100);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(400, 524);
            mainPanel.TabIndex = 0;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 700);
            Controls.Add(mainPanel);
            Name = "SignUp";
            Text = "SignUp";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Panel mainPanel;
    }
}