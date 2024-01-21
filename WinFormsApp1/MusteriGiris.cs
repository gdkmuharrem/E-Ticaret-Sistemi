using System.Data;

namespace WinFormsApp1
{
    public partial class MusteriGiris : Form
    {
        MusteriSepet Sepet;
        public DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();
        public string KullaniciAd;
        public MusteriGiris()
        {
            InitializeComponent();
            InitializeComponent();
            dt2.Columns.Add("CategoryName", typeof(string));
            dt2.Columns.Add("ProductName", typeof(string));
            dt2.Columns.Add("Price", typeof(decimal));
            dt2.Columns.Add("Adet", typeof(int));
            dt2.Columns.Add("ToplamTutar", typeof(decimal));
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Adet", typeof(int));
            dt.Columns.Add("ToplamTutar", typeof(decimal));
        }
        public void KAd(string KAd)
        {
            KullaniciAd = KAd;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MusteriYeniSiparis yniSprs = new MusteriYeniSiparis();
            yniSprs.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MergeDataTable(dt, dt2);
            if (Sepet == null || Sepet.IsDisposed)
            {
                Sepet = new MusteriSepet();
                Sepet.BilgiEkle(dt);
                Sepet.KAd(KullaniciAd);
                Sepet.Show();
            }
            if (Sepet != null)
            {
                Sepet.BilgiEkle(dt);
                Sepet.KAd(KullaniciAd);
                Sepet.Show();
            }
        }
        public void MergeDataTableWithoutClear(DataTable destinationTable, DataTable sourceTable)
        {
            // DataTable'ları birleştirme (ekleme)
            destinationTable.Clear();
            foreach (DataRow row in sourceTable.Rows)
            {
                destinationTable.ImportRow(row);
            }
        }
        public void MergeDataTable(DataTable destinationTable, DataTable sourceTable)
        {
            // DataTable'ları birleştirme (ekleme)
            foreach (DataRow sourceRow in sourceTable.Rows)
            {
                bool rowExists = false;

                // Hedef DataTable'da her bir satırı kontrol et
                foreach (DataRow destinationRow in destinationTable.Rows)
                {
                    // Satırları karşılaştır
                    if (DataRowEquals(sourceRow, destinationRow))
                    {
                        rowExists = true;
                        break;
                    }
                }

                // Eğer aynı satır yoksa ekleyin
                if (!rowExists)
                {
                    destinationTable.ImportRow(sourceRow);
                }
            }
        }

        private bool DataRowEquals(DataRow row1, DataRow row2)
        {
            // Satırları karşılaştır
            for (int i = 0; i < row1.ItemArray.Length; i++)
            {
                if (!row1.ItemArray[i].Equals(row2.ItemArray[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private void MusteriGiris_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
