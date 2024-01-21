using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminSilinmisKayit : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        private DataTable originalDataTable;
        public AdminSilinmisKayit()
        {
            InitializeComponent();
        }

        private void AdminSilinmisKayit_Load(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusu
                string query = "SELECT * FROM DeletedRecords";

                // SQL sorgusunu çalıştırmak için bir SqlDataAdapter ve bir DataTable kullanılır.
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                originalDataTable = new DataTable(); // Orijinal DataTable'ı sınıf seviyesinde tanımlanan değişkenle eşleştiriyoruz.

                // Verileri çek ve DataGridView'i doldur
                adapter.Fill(originalDataTable);
                dataGridView1.DataSource = originalDataTable;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (originalDataTable != null)
            {
                string aramaMetni = textBox1.Text.Trim();

                // Orijinal DataTable'ın bir kopyasını al
                DataTable filteredDataTable = originalDataTable.Clone();

                // DataView oluşturup orijinal DataTable'ı filtreliyoruz.
                DataView dv = originalDataTable.DefaultView;

                if (DateTime.TryParseExact(aramaMetni, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tarih))
                {
                    DateTime baslangicTarihi = tarih.Date;
                    DateTime bitisTarihi = baslangicTarihi.AddDays(1).AddSeconds(-1);

                    dv.RowFilter = $"DeletedAt >= #{baslangicTarihi.ToString("yyyy-MM-dd HH:mm:ss")}# AND DeletedAt <= #{bitisTarihi.ToString("yyyy-MM-dd HH:mm:ss")}#";
                }


                else
                {
                    // Eğer aramaMetni metin bir değerse
                    dv.RowFilter = $"Table_Name LIKE '%{aramaMetni}%' OR Record_ID LIKE '%{aramaMetni}%'";

                }

                // Filtrelenmiş verileri kopyalanmış DataTable'a ekliyoruz.
                foreach (DataRowView drv in dv)
                {
                    filteredDataTable.ImportRow(drv.Row);
                }

                // Kopyalanmış DataTable'ı DataGridView'e yüklüyoruz.
                dataGridView1.DataSource = filteredDataTable;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
