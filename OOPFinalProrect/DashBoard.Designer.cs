namespace OOPFinalProrect
{
    partial class DashBoard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(447, 57);
            label1.Name = "label1";
            label1.Size = new Size(267, 50);
            label1.TabIndex = 0;
            label1.Text = "Student Forms";
            // 
            // button1
            // 
            button1.Location = new Point(242, 152);
            button1.Name = "button1";
            button1.Size = new Size(207, 103);
            button1.TabIndex = 1;
            button1.Text = "Student Registration Form";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(242, 284);
            button2.Name = "button2";
            button2.Size = new Size(207, 103);
            button2.TabIndex = 2;
            button2.Text = "Attendance Form";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(507, 152);
            button3.Name = "button3";
            button3.Size = new Size(207, 103);
            button3.TabIndex = 3;
            button3.Text = "Grades Entry Form";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(507, 284);
            button4.Name = "button4";
            button4.Size = new Size(207, 103);
            button4.TabIndex = 4;
            button4.Text = "Fee Payment Form";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(747, 230);
            button5.Name = "button5";
            button5.Size = new Size(207, 103);
            button5.TabIndex = 5;
            button5.Text = "Time Table Scheduling Form";
            button5.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 535);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "DashBoard";
            Text = "DashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}