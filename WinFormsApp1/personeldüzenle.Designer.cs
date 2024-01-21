namespace WinFormsApp1
{
    partial class personeldüzenle
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 264);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 314);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(492, 175);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 7;
            button1.Text = "Değişikleri Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(561, 94);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 8;
            label1.Text = "username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 9;
            label2.Text = "Çalışan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 101);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "Adı :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 47);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Parola :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 164);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 12;
            label5.Text = "Soyadı :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 271);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 13;
            label6.Text = "Telefon No :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 221);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 14;
            label7.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 321);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 15;
            label8.Text = "Maaş :";
            // 
            // personeldüzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "personeldüzenle";
            Text = "personeldüzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}