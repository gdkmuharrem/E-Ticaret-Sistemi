using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Personel_Gecmis_Siparis : Form
    {
        public Personel_Gecmis_Siparis()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        private DataTable originalDataTable;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusu
                string query = "SELECT * FROM OrderHistory";

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

                // Eğer aramaMetni sayısal bir değerse
                if (int.TryParse(aramaMetni, out _))
                {
                    dv.RowFilter = $"OrderHistoryID = {aramaMetni}";
                }
                else
                {
                    // Eğer aramaMetni metin bir değerse
                    dv.RowFilter = $"CustomerUsername LIKE '%{aramaMetni}%'";
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


        private void Personel_Gecmis_Siparis_Load(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
