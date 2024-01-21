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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class personeldüzenle : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public personeldüzenle(string username, string password, string name, string lastname, string email, string phone, string salary)
        {
            InitializeComponent();

            // TextBox'lara verileri ata
            label1.Text = username;
            textBox2.Text = password;
            textBox3.Text = name;
            textBox4.Text = lastname;
            textBox5.Text = email;
            textBox6.Text = phone;
            textBox7.Text = salary;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "")
            {
                string kullanici_adi = label1.Text;
                string sifre = textBox2.Text;
                string ad = textBox3.Text;
                string soyAd = textBox4.Text;
                string telefon = textBox5.Text;
                string mail = textBox6.Text;
                string maas = textBox7.Text;

                string query = "UPDATE Employee SET EmployeePassword=@sifre,FirstName=@ad,LastName=@soyAd,Phone=@telefon,Email=@mail,Salary=@maas WHERE EmployeeUsername = @kullanici_adi";

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
                        command.Parameters.AddWithValue("@maas", maas);

                        int affectedRows = command.ExecuteNonQuery();

                        // Sonuçları gösterin.
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                            Personel p = Application.OpenForms["Personel"] as Personel;
                            p.goster();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı güncellenemedi.");
                        }
                    }
                }
            }
        }

        private void personeldüzenle_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
