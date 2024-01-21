namespace WinFormsApp1
{
    partial class AdminMusteri
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
            dataGridView1 = new DataGridView();
            btnAra = new Button();
            btnDuzenle = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            txtTel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            txtArama = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(806, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(751, 13);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 51);
            btnAra.TabIndex = 1;
            btnAra.Text = "Kullanıcı Arama";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(751, 124);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(94, 29);
            btnDuzenle.TabIndex = 3;
            btnDuzenle.Text = "Güncelle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(144, 117);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(144, 163);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(349, 25);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(349, 72);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 117);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 8;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 163);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 9;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 25);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 10;
            label3.Text = "Mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 72);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "Telefon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 25);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 13;
            label5.Text = "Kullanıcı Adı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 71);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 14;
            label6.Text = "Şifre :";
            // 
            // txtKullanici
            // 
            txtKullanici.Enabled = false;
            txtKullanici.Location = new Point(144, 25);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(125, 27);
            txtKullanici.TabIndex = 15;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(144, 71);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 16;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(619, 25);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 28);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 18;
            label7.Text = "İsme Göre Arama :";
            // 
            // AdminMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 453);
            Controls.Add(label7);
            Controls.Add(txtArama);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTel);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnDuzenle);
            Controls.Add(btnAra);
            Controls.Add(dataGridView1);
            Name = "AdminMusteri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musteri Bilgileri";
            Load += Musteri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAra;
        private Button btnDuzenle;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private TextBox txtTel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private TextBox txtArama;
        private Label label7;
    }
}