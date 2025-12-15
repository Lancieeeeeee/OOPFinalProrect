namespace OOPFinalProrect
{
    partial class FeeTrackingSys
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
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            panel1 = new Panel();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 129);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 164);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Fee Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 203);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Due date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 247);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Payment Due:";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(106, 247);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 112);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 44);
            label5.Name = "label5";
            label5.Size = new Size(382, 36);
            label5.TabIndex = 0;
            label5.Text = "Fee Payment Management";
            // 
            // button1
            // 
            button1.Location = new Point(12, 302);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Add Payment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 331);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 360);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 178);
            dataGridView1.TabIndex = 1;
            // 
            // FeeTrackingSys
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 657);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FeeTrackingSys";
            Text = "FeeTrackingSys";
            Load += FeeTrackingSys_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel panel1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}