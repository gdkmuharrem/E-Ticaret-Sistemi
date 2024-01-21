namespace WinFormsApp1
{
    partial class MusteriYeniSiparis
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(368, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Akıllı Telefon", "Klavye", "Tişört", "Çanta" });
            comboBox2.Location = new Point(368, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(368, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(368, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Kategoriler :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Ürünler :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 130);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Ürün Fiyatı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 173);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Adet :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 217);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 9;
            label5.Text = "Toplam Fiyat :";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox3.Location = new Point(368, 173);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 23);
            comboBox3.TabIndex = 10;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(392, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 11;
            button1.Text = "Sepete Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MusteriYeniSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 340);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "MusteriYeniSiparis";
            Text = "MusteriYeniSiparis";
            FormClosing += MusteriYeniSiparis_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private Button button1;
    }
}