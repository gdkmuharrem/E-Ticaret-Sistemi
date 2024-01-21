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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "")
            {
                string kullanici_adi = textBox1.Text;
                string sifre = textBox2.Text;
                string ad = textBox3.Text;
                string soyAd = textBox4.Text;
                string telefon = textBox5.Text;
                string mail = textBox6.Text;
                string maas = textBox8.Text;

                string query = "INSERT INTO Employee(EmployeeUsername, EmployeePassword, FirstName, LastName, Phone, Email, Salary)VALUES(@kullanici_adi, @sifre, @ad, @soyAd, @telefon, @mail,@maas )";

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
                        command.Parameters.AddWithValue("maas", maas);

                        int affectedRows = command.ExecuteNonQuery();

                        // Sonuçları gösterin.
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Yeni kullanıcı başarıyla eklendi.");
                            Personel p = Application.OpenForms["Personel"] as Personel;
                            p.goster();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı eklenemedi.");
                        }
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
