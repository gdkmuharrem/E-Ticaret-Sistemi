using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlýsveris;Integrated Security=True";

        public static string kullanici_adi { get; private set; }

        public void Baglanti()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Baðlantý Baþarýlý!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Baðlantý Baþarýsýz: " + ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Baglanti();
            kullanici_adi = textBox1.Text;
            string sifre = textBox2.Text;

            string query = "SELECT CustomerUsername, CustomerPassword FROM Customers WHERE  CustomerUsername= @kullanici_adi AND  CustomerPassword= @sifre";
            string query2 = "SELECT EmployeeUsername, EmployeePassword FROM Employee WHERE  EmployeeUsername= @kullanici_adi2 AND  EmployeePassword= @sifre2";
            string query3 = "SELECT AdminUserName, AdminPassword FROM Admin WHERE  AdminUserName= @kullanici_adi3 AND  AdminPassword= @sifre3";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MusteriGirisPaneli pnlcstmr = new MusteriGirisPaneli();
                            pnlcstmr.KAd(kullanici_adi);
                            pnlcstmr.Show();
                            this.Hide();
                        }
                        else
                        {
                            reader.Close();
                            using (SqlCommand command2 = new SqlCommand(query2, connection))
                            {
                                command2.Parameters.AddWithValue("@kullanici_adi2", kullanici_adi);
                                command2.Parameters.AddWithValue("@sifre2", sifre);

                                using (SqlDataReader reader2 = command2.ExecuteReader())
                                {
                                    if (reader2.HasRows)
                                    {
                                        personelgiris pEmployee = new personelgiris();
                                        pEmployee.Kname = kullanici_adi;
                                        pEmployee.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        reader2.Close();
                                        using (SqlCommand command3 = new SqlCommand(query3, connection))
                                        {
                                            command3.Parameters.AddWithValue("@kullanici_adi3", kullanici_adi);
                                            command3.Parameters.AddWithValue("@sifre3", sifre);

                                            using (SqlDataReader reader3 = command3.ExecuteReader())
                                            {
                                                if (reader3.HasRows)
                                                {
                                                    Form pAdmin = new giris();
                                                    pAdmin.Show();
                                                    this.Hide();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Hatalý kullanýcý adý veya þifre !");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form pkayýt = new Kayýt();
            pkayýt.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}