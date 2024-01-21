using System.Drawing;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class giris : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public giris()
        {
            InitializeComponent();
            random = new Random();
        }

        private void giris_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form pUrun = new Urun();
            OpenChildForm(new Urun(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Personel = new Personel();
            OpenChildForm(new Personel(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form pKarZarar = new KarZarar1();
            OpenChildForm(new KarZarar1(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form pMusteri = new AdminMusteri();
            OpenChildForm(new AdminMusteri(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Yedekle yedekle = new Yedekle();
            OpenChildForm(new Yedekle(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form pSiparis2 = new AdminSilinmisKayit();
            OpenChildForm(pSiparis2, sender);
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Form pSiparis1 = new Aktif_Siparis();
            OpenChildForm(new Aktif_Siparis(), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form GSiparis1 = new Gecmis_Siparis();
            OpenChildForm(new Gecmis_Siparis(), sender);
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
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