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
    public partial class PersonelMusteri : Form
    {

        SqlConnection connection;
        SqlCommand komut;
        SqlDataAdapter da;

        public PersonelMusteri()
        {
            InitializeComponent();
        }

        void MusteriGetir()
        {
            connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True");
            connection.Open();
            da = new SqlDataAdapter("SELECT CustomerUsername, FirstName, LastName, Email, Phone FROM Customers", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select CustomerUsername, FirstName, LastName, Email, Phone from Customers where FirstName like '%" + txtArama.Text + "%'", connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }



        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Customers SET FirstName=@FirstName,LastName=@LastName,Email=@Email,Phone=@Phone WHERE CustomerUsername=@CustomerUsername";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@CustomerUsername", Convert.ToString(txtKullanici.Text));
            komut.Parameters.AddWithValue("@FirstName", txtAd.Text);
            komut.Parameters.AddWithValue("@LastName", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Email", txtMail.Text);
            komut.Parameters.AddWithValue("@Phone", txtTel.Text);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            MusteriGetir();
            MessageBox.Show("Müşteri Güncellendi.");
        }


        private void PersonelMusteri_Load(object sender, EventArgs e)
        {
            MusteriGetir();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKullanici.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

    }
}
