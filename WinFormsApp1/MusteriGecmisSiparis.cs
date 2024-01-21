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
    public partial class MusteriGecmisSiparis : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        public DataTable dataTable;
        public DataTable dataTable2;
        public MusteriGecmisSiparis()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        public void Onaylanan()
        {
            string kullaniciAdi = Form1.kullanici_adi;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusu

                string query = "EXEC GetOrderHistoryByCustomer @kullaniciAdi = @kullaniciAdi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleyin
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    // SQL sorgusunu çalıştırmak için bir SqlDataAdapter ve bir DataTable kullanılır.
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();

                    // Verileri çek ve DataGridView'i doldur
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        public void OnayBekleyen()
        {
            string kullaniciAdi = Form1.kullanici_adi;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusu
                string query = "SELECT * FROM Orders WHERE CustomerUsername = @kullaniciAdi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleyin
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    // SQL sorgusunu çalıştırmak için bir SqlDataAdapter ve bir DataTable kullanılır.
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable2 = new DataTable();

                    // Verileri çek ve DataGridView'i doldur
                    adapter.Fill(dataTable2);
                    dataGridView1.DataSource = dataTable2;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                OnayBekleyen();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Onaylanan();
            }
        }
    }
}
