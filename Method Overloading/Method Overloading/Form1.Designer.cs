namespace Method_Overloading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(121, 231);
            button1.Name = "button1";
            button1.Size = new Size(65, 34);
            button1.TabIndex = 0;
            button1.Text = "Circle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 373);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(364, 231);
            button2.Name = "button2";
            button2.Size = new Size(78, 34);
            button2.TabIndex = 4;
            button2.Text = "Rectangle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(333, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(333, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(137, 200);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 7;
            label1.Text = "Radius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(387, 135);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 8;
            label2.Text = "Lenght";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(387, 200);
            label3.Name = "label3";
            label3.Size = new Size(41, 16);
            label3.TabIndex = 9;
            label3.Text = "Width";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(575, 109);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(575, 174);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 23);
            textBox6.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(638, 135);
            label4.Name = "label4";
            label4.Size = new Size(34, 16);
            label4.TabIndex = 12;
            label4.Text = "Base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(625, 200);
            label5.Name = "label5";
            label5.Size = new Size(45, 16);
            label5.TabIndex = 13;
            label5.Text = "Height";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(601, 231);
            button3.Name = "button3";
            button3.Size = new Size(86, 34);
            button3.TabIndex = 14;
            button3.Text = "Triangle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(387, 399);
            label6.Name = "label6";
            label6.Size = new Size(34, 16);
            label6.TabIndex = 15;
            label6.Text = "Area";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Finding Areas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Button button3;
        private Label label6;
    }
}
