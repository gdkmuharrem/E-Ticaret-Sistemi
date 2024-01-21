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
    public partial class Personel : Form
    {
        // Veritabanı bağlantı dizesi
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
        public Personel()
        {
            InitializeComponent();
        }
        private DataTable dataTable;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string employeeUsername = dataGridView1.SelectedRows[0].Cells["EmployeeUsername"].Value.ToString();

                // Veriyi sil
                string deleteQuery = "DELETE FROM Employee WHERE EmployeeUsername = @EmployeeUsername";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeUsername", employeeUsername);
                        command.ExecuteNonQuery();
                    }
                }

                // DataGridView'dan seçilen satırı kaldır
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form pkayıt = new Form2();
            pkayıt.ShowDialog();

        }
        public void goster()
        {
            dataGridView1.DataSource = null;
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusu
                string query = "SELECT * FROM Employee";

                // SQL sorgusunu çalıştırmak için bir SqlDataAdapter ve bir DataTable kullanılır.
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Verileri çek ve DataGridView'i doldur
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusu
                string query = "SELECT * FROM Employee";

                // SQL sorgusunu çalıştırmak için bir SqlDataAdapter ve bir DataTable kullanılır.
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Verileri çek ve DataGridView'i doldur
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanıcı bir satır seçti mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki verileri al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string username = selectedRow.Cells["EmployeeUsername"].Value.ToString();
                string password = selectedRow.Cells["EmployeePassword"].Value.ToString();
                string name = selectedRow.Cells["FirstName"].Value.ToString();
                string lastname = selectedRow.Cells["LastName"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string salary = selectedRow.Cells["Salary"].Value.ToString();

                // Diğer formu oluştur ve verileri ileterek göster
                personeldüzenle otherForm = new personeldüzenle(username, password, name, lastname, email, phone, salary);
                otherForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
        }
    }
}
