namespace WinFormsApp1
{
    partial class PersonelMusteri
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
            label7 = new Label();
            txtArama = new TextBox();
            txtKullanici = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTel = new TextBox();
            txtMail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            btnDuzenle = new Button();
            btnAra = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 39);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 37;
            label7.Text = "İsme Göre Arama :";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(629, 36);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 36;
            // 
            // txtKullanici
            // 
            txtKullanici.Enabled = false;
            txtKullanici.Location = new Point(153, 24);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(125, 27);
            txtKullanici.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 24);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 32;
            label5.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 71);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 30;
            label4.Text = "Telefon :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 24);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 29;
            label3.Text = "Mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 115);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 28;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 68);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 27;
            label1.Text = "Ad :";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(358, 71);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 26;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(358, 24);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 25;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(153, 115);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 24;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(153, 68);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 23;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(760, 155);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(94, 29);
            btnDuzenle.TabIndex = 22;
            btnDuzenle.Text = "Güncelle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(760, 24);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 51);
            btnAra.TabIndex = 20;
            btnAra.Text = "Kullanıcı Arama";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(806, 231);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // PersonelMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 453);
            Controls.Add(label7);
            Controls.Add(txtArama);
            Controls.Add(txtKullanici);
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
            Name = "PersonelMusteri";
            Text = "Müşteri Bilgileri";
            Load += PersonelMusteri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtArama;
        private TextBox txtKullanici;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTel;
        private TextBox txtMail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnDuzenle;
        private Button btnAra;
        private DataGridView dataGridView1;
    }
}