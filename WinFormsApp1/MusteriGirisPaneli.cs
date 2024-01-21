namespace WinFormsApp1
{
    public partial class MusteriGirisPaneli : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public string KullaniciAd;
        public MusteriGirisPaneli()
        {
            InitializeComponent();
            random = new Random();
        }
        public void KAd(string KAd)
        {
            KullaniciAd = KAd;
        }
        private void buttonBilgilerim_Click(object sender, EventArgs e)
        {
            MusteriBilgilerim mstrBlg = new MusteriBilgilerim();
            mstrBlg.KName = KullaniciAd;
            OpenChildForm(mstrBlg, sender);
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkSlateGray;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);

                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void buttonsiparisal_Click(object sender, EventArgs e)
        {
            MusteriGiris mstrGiris = new MusteriGiris();
            mstrGiris.KAd(KullaniciAd);
            OpenChildForm(mstrGiris, sender);
        }
        private void buttongsiparis_Click(object sender, EventArgs e)
        {
            MusteriGecmisSiparis gcmsSprs = new MusteriGecmisSiparis();
            OpenChildForm(gcmsSprs, sender);
        }

        private void MusteriGirisPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Uygulamayý kapatmak istediðinizden emin misiniz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Kapatmayý iptal et
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}