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
    public partial class MusteriBilgilerim : Form
    {
        private List<Customer> customerList;
        public string KName;
        public MusteriBilgilerim()
        {
            InitializeComponent();
        }
        private void MusteriBilgilerim_Load(object sender, EventArgs e)
        {
            customerList = GetCustomerDataFromDatabase();
            if (customerList.Count > 0)
            {
                FillTextBoxes(customerList[0]);
            }
        }
        private void FillTextBoxes(Customer customer)
        {
            // Verileri TextBox'lara yerleştir
            textBox1.Text = customer.CustomerUsername;
            textBox2.Text = customer.CustomerPassword;
            textBox3.Text = customer.FirstName;
            textBox4.Text = customer.LastName;
            textBox5.Text = customer.Email;
            textBox6.Text = customer.Phone;
        }
        private List<Customer> GetCustomerDataFromDatabase()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "EXEC GetCustomerInfo @CustomerUsername";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // @CustomerUsername parametresine değeri atayın
                        command.Parameters.AddWithValue("@CustomerUsername", KName.ToString());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Customer customer = new Customer
                                {
                                    CustomerUsername = reader["CustomerUsername"].ToString(),
                                    CustomerPassword = reader["CustomerPassword"].ToString(),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"].ToString()
                                };

                                customers.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanından veri alınırken bir hata oluştu: " + ex.Message);
            }

            return customers;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Güncellenecek verileri al
            string newPassword = textBox2.Text;
            string newEmail = textBox5.Text;
            string newPhone = textBox6.Text;

            // Güncelleme sorgusunu oluştur
            string updateQuery = "UPDATE Customers SET CustomerPassword = @NewPassword, Email = @NewEmail, Phone = @NewPhone WHERE CustomerUsername = @CustomerUsername";

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Parametreleri ekleyin
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@NewEmail", newEmail);
                        command.Parameters.AddWithValue("@NewPhone", newPhone);
                        command.Parameters.AddWithValue("@CustomerUsername", KName);
                        // Sorguyu çalıştırın
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Veriler başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu veya herhangi bir veri güncellenmedi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

    }
    public class Customer
    {
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

