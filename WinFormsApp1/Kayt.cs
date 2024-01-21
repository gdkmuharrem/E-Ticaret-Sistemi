using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
            textBox3.Focus();
        }

        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        public void Baglanti()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Bağlantı Başarılı!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Bağlantı Başarısız: " + ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Baglanti();
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "")
            {
                string kullanici_adi = textBox1.Text;
                string sifre = textBox2.Text;
                string ad = textBox3.Text;
                string soyAd = textBox4.Text;
                string telefon = textBox5.Text;
                string mail = textBox6.Text;

                string query = "INSERT INTO Customers(CustomerUsername, CustomerPassword, FirstName, LastName, Phone, Email)VALUES(@kullanici_adi, @sifre, @ad, @soyAd, @telefon, @mail)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
                        command.Parameters.AddWithValue("@sifre", sifre);
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyAd", soyAd);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@mail", mail);

                        int affectedRows = command.ExecuteNonQuery();

                        // Sonuçları gösterin.
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Yeni kullanıcı başarıyla eklendi.");
                            Form pgiris = new Form1();
                            pgiris.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı eklenemedi.");
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
