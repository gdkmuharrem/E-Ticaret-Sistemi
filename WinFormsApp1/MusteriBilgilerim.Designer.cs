namespace WinFormsApp1
{
    partial class MusteriBilgilerim
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
            button1 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(445, 355);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 52);
            button1.TabIndex = 25;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(417, 310);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(417, 254);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(417, 198);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(417, 142);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(417, 86);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(417, 30);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 314);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 18;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 258);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 17;
            label5.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 202);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 16;
            label4.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 146);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 15;
            label3.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 90);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 14;
            label2.Text = "Sifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 34);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Adı";
            // 
            // MusteriBilgilerim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 453);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MusteriBilgilerim";
            Text = "MusteriBilgilerim";
            Load += MusteriBilgilerim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}