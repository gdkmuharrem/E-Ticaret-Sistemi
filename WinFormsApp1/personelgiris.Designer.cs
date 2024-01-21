namespace WinFormsApp1
{
    partial class personelgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelgiris));
            panelMenu = new Panel();
            button5 = new Button();
            button1 = new Button();
            buttongsiparis = new Button();
            buttonurunler = new Button();
            buttonbilgilerim = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateGray;
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(buttongsiparis);
            panelMenu.Controls.Add(buttonurunler);
            panelMenu.Controls.Add(buttonbilgilerim);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 580);
            panelMenu.TabIndex = 6;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 320);
            button5.Name = "button5";
            button5.Padding = new Padding(12, 0, 0, 0);
            button5.Size = new Size(220, 60);
            button5.TabIndex = 13;
            button5.Text = "  Müşteri Blgi";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 260);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(220, 60);
            button1.TabIndex = 12;
            button1.Text = " Geçmiş Siparişler";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // buttongsiparis
            // 
            buttongsiparis.Dock = DockStyle.Top;
            buttongsiparis.FlatAppearance.BorderSize = 0;
            buttongsiparis.FlatStyle = FlatStyle.Flat;
            buttongsiparis.ForeColor = Color.White;
            buttongsiparis.Image = (Image)resources.GetObject("buttongsiparis.Image");
            buttongsiparis.ImageAlign = ContentAlignment.MiddleLeft;
            buttongsiparis.Location = new Point(0, 200);
            buttongsiparis.Name = "buttongsiparis";
            buttongsiparis.Padding = new Padding(12, 0, 0, 0);
            buttongsiparis.Size = new Size(220, 60);
            buttongsiparis.TabIndex = 11;
            buttongsiparis.Text = "  Aktif Siparişler";
            buttongsiparis.TextAlign = ContentAlignment.MiddleLeft;
            buttongsiparis.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttongsiparis.UseVisualStyleBackColor = true;
            buttongsiparis.Click += buttongsiparis_Click;
            // 
            // buttonurunler
            // 
            buttonurunler.Dock = DockStyle.Top;
            buttonurunler.FlatAppearance.BorderSize = 0;
            buttonurunler.FlatStyle = FlatStyle.Flat;
            buttonurunler.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonurunler.ForeColor = Color.White;
            buttonurunler.Image = Properties.Resources.shopping_cart__1_;
            buttonurunler.ImageAlign = ContentAlignment.MiddleLeft;
            buttonurunler.Location = new Point(0, 140);
            buttonurunler.Name = "buttonurunler";
            buttonurunler.Padding = new Padding(12, 0, 0, 0);
            buttonurunler.Size = new Size(220, 60);
            buttonurunler.TabIndex = 10;
            buttonurunler.Text = "  Ürünler";
            buttonurunler.TextAlign = ContentAlignment.MiddleLeft;
            buttonurunler.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonurunler.UseVisualStyleBackColor = true;
            buttonurunler.Click += buttonurunler_Click;
            // 
            // buttonbilgilerim
            // 
            buttonbilgilerim.Dock = DockStyle.Top;
            buttonbilgilerim.FlatAppearance.BorderSize = 0;
            buttonbilgilerim.FlatStyle = FlatStyle.Flat;
            buttonbilgilerim.ForeColor = Color.White;
            buttonbilgilerim.Image = (Image)resources.GetObject("buttonbilgilerim.Image");
            buttonbilgilerim.ImageAlign = ContentAlignment.MiddleLeft;
            buttonbilgilerim.Location = new Point(0, 80);
            buttonbilgilerim.Name = "buttonbilgilerim";
            buttonbilgilerim.Padding = new Padding(12, 0, 0, 0);
            buttonbilgilerim.Size = new Size(220, 60);
            buttonbilgilerim.TabIndex = 7;
            buttonbilgilerim.Text = "  Bilgilerim";
            buttonbilgilerim.TextAlign = ContentAlignment.MiddleLeft;
            buttonbilgilerim.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonbilgilerim.UseVisualStyleBackColor = true;
            buttonbilgilerim.Click += buttonbilgilerim_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 11);
            label1.Name = "label1";
            label1.Size = new Size(70, 33);
            label1.TabIndex = 1;
            label1.Text = "D.Ü.";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Teal;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(967, 80);
            panelTitleBar.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(405, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(92, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(220, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(967, 500);
            panelDesktopPanel.TabIndex = 8;
            panelDesktopPanel.Paint += panelDesktopPanel_Paint;
            // 
            // personelgiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 580);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "personelgiris";
            Text = "personelgiris";
            FormClosing += personelgiris_FormClosing;
            Load += personelgiris_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button buttongsiparis;
        private Button buttonurunler;
        private Button buttonbilgilerim;
        private Panel panelLogo;
        private Label label1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Button button1;
        private Button button5;
    }
}