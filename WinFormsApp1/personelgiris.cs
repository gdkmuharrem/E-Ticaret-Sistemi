using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class personelgiris : Form
    {
        public string Kname;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public personelgiris()
        {
            InitializeComponent();
            random = new Random();
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


        private void personelgiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Kapatmayı iptal et
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void personelgiris_Load(object sender, EventArgs e)
        {

        }

        private void buttonbilgilerim_Click(object sender, EventArgs e)
        {
            personelBilgilerim Pbilgi = new personelBilgilerim();
            Pbilgi.KName = Kname;
            OpenChildForm(Pbilgi, sender);
        }

        private void buttonurunler_Click(object sender, EventArgs e)
        {
            Form Purun = new Urun();
            OpenChildForm(Purun, sender);
        }

        private void buttongsiparis_Click(object sender, EventArgs e)
        {
            Form personel = new Aktif_Siparis();
            OpenChildForm(personel, sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form pSiparisgecmis1 = new Personel_Gecmis_Siparis();
            OpenChildForm(pSiparisgecmis1, sender);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form Pmüsteri = new PersonelMusteri();
            OpenChildForm(Pmüsteri, sender);
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}