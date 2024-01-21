namespace WinFormsApp1
{
    partial class Kayıt
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
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(222, 52);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 0;
            label11.Text = "Kullanıcı Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(259, 93);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 1;
            label12.Text = "Parola";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(326, 41);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(326, 83);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 6;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(272, 168);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 49);
            button1.TabIndex = 4;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(479, 264);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.Location = new Point(83, 187);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Location = new Point(83, 132);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Location = new Point(83, 75);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(83, 31);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 143);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 197);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 7;
            label10.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "SoyAd";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 5;
            label1.Text = "Ad";
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 299);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Kayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt";
            Load += Kayıt_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label11;
        private Label label12;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label10;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}