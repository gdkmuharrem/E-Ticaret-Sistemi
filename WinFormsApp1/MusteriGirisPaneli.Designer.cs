namespace WinFormsApp1
{
    partial class MusteriGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGirisPaneli));
            panelMenu = new Panel();
            buttongsiparis = new Button();
            buttonsepet = new Button();
            buttonBilgilerim = new Button();
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
            panelMenu.Controls.Add(buttongsiparis);
            panelMenu.Controls.Add(buttonsepet);
            panelMenu.Controls.Add(buttonBilgilerim);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 580);
            panelMenu.TabIndex = 0;
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
            buttongsiparis.Padding = new Padding(11, 0, 0, 0);
            buttongsiparis.Size = new Size(219, 60);
            buttongsiparis.TabIndex = 11;
            buttongsiparis.Text = "  Siparişlerim";
            buttongsiparis.TextAlign = ContentAlignment.MiddleLeft;
            buttongsiparis.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttongsiparis.UseVisualStyleBackColor = true;
            buttongsiparis.Click += buttongsiparis_Click;
            // 
            // buttonsepet
            // 
            buttonsepet.Dock = DockStyle.Top;
            buttonsepet.FlatAppearance.BorderSize = 0;
            buttonsepet.FlatStyle = FlatStyle.Flat;
            buttonsepet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonsepet.ForeColor = Color.White;
            buttonsepet.Image = Properties.Resources.shopping_cart__1_;
            buttonsepet.ImageAlign = ContentAlignment.MiddleLeft;
            buttonsepet.Location = new Point(0, 140);
            buttonsepet.Name = "buttonsepet";
            buttonsepet.Padding = new Padding(11, 0, 0, 0);
            buttonsepet.Size = new Size(219, 60);
            buttonsepet.TabIndex = 10;
            buttonsepet.Text = "Sipariş Oluştur";
            buttonsepet.TextAlign = ContentAlignment.MiddleLeft;
            buttonsepet.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonsepet.UseVisualStyleBackColor = true;
            buttonsepet.Click += buttonsiparisal_Click;
            // 
            // buttonBilgilerim
            // 
            buttonBilgilerim.Dock = DockStyle.Top;
            buttonBilgilerim.FlatAppearance.BorderSize = 0;
            buttonBilgilerim.FlatStyle = FlatStyle.Flat;
            buttonBilgilerim.ForeColor = Color.White;
            buttonBilgilerim.Image = (Image)resources.GetObject("buttonBilgilerim.Image");
            buttonBilgilerim.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBilgilerim.Location = new Point(0, 80);
            buttonBilgilerim.Name = "buttonBilgilerim";
            buttonBilgilerim.Padding = new Padding(11, 0, 0, 0);
            buttonBilgilerim.Size = new Size(219, 60);
            buttonBilgilerim.TabIndex = 7;
            buttonBilgilerim.Text = "  Bilgilerim";
            buttonBilgilerim.TextAlign = ContentAlignment.MiddleLeft;
            buttonBilgilerim.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBilgilerim.UseVisualStyleBackColor = true;
            buttonBilgilerim.Click += buttonBilgilerim_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 21);
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
            panelTitleBar.Location = new Point(219, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(968, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(407, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(92, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(219, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(968, 500);
            panelDesktopPanel.TabIndex = 2;
            // 
            // MusteriGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 580);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MusteriGirisPaneli";
            Text = "MusteriGiris";
            FormClosing += MusteriGirisPaneli_FormClosing;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonBilgilerim;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Label label1;
        private Button buttongsiparis;
        private Button buttonsepet;
    }
}