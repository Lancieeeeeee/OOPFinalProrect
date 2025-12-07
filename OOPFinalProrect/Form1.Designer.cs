namespace OOPFinalProrect
{
    partial class Form1
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
            mainPanel = new Panel();
            loginPanel = new Panel();
            signupLabel = new Label();
            loginButton = new Button();
            forgotPasswordLabel = new Label();
            rememberMeCheckBox = new CheckBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            loginTitleLabel = new Label();
            closeButton = new Button();
            mainPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(25, 25, 112);
            mainPanel.Controls.Add(loginPanel);
            mainPanel.Controls.Add(closeButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 600);
            mainPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.FromArgb(45, 45, 48);
            loginPanel.Controls.Add(signupLabel);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(forgotPasswordLabel);
            loginPanel.Controls.Add(rememberMeCheckBox);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(usernameTextBox);
            loginPanel.Controls.Add(loginTitleLabel);
            loginPanel.Location = new Point(200, 100);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(400, 400);
            loginPanel.TabIndex = 0;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Cursor = Cursors.Hand;
            signupLabel.Font = new Font("Segoe UI", 9F);
            signupLabel.ForeColor = Color.White;
            signupLabel.Location = new Point(160, 360);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(61, 15);
            signupLabel.TabIndex = 7;
            signupLabel.Text = "or Sign up";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(41, 121, 255);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(50, 300);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(300, 40);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Cursor = Cursors.Hand;
            forgotPasswordLabel.Font = new Font("Segoe UI", 9F);
            forgotPasswordLabel.ForeColor = Color.FromArgb(41, 121, 255);
            forgotPasswordLabel.Location = new Point(280, 270);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(100, 15);
            forgotPasswordLabel.TabIndex = 5;
            forgotPasswordLabel.Text = "Forgot Password?";
            // 
            // rememberMeCheckBox
            // 
            rememberMeCheckBox.AutoSize = true;
            rememberMeCheckBox.Font = new Font("Segoe UI", 9F);
            rememberMeCheckBox.ForeColor = Color.White;
            rememberMeCheckBox.Location = new Point(50, 270);
            rememberMeCheckBox.Name = "rememberMeCheckBox";
            rememberMeCheckBox.Size = new Size(104, 19);
            rememberMeCheckBox.TabIndex = 4;
            rememberMeCheckBox.Text = "Remember Me";
            rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(60, 60, 64);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(50, 210);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 16);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(60, 60, 64);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(50, 130);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 16);
            usernameTextBox.TabIndex = 2;
            // 
            // loginTitleLabel
            // 
            loginTitleLabel.AutoSize = true;
            loginTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            loginTitleLabel.ForeColor = Color.White;
            loginTitleLabel.Location = new Point(160, 50);
            loginTitleLabel.Name = "loginTitleLabel";
            loginTitleLabel.Size = new Size(113, 45);
            loginTitleLabel.TabIndex = 1;
            loginTitleLabel.Text = "Log in";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(750, 10);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 10;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            mainPanel.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Button closeButton;
    }
}