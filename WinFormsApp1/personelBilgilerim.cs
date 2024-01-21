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
    public partial class personelBilgilerim : Form
    {
        private List<Employee> employeeList;
        public personelBilgilerim()
        {
            InitializeComponent();
        }
        public string KName;
        private void personelBilgilerim_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde veritabanından verileri al
            employeeList = GetEmployeeDataFromDatabase();

            // Verileri TextBox'lara yerleştir
            if (employeeList.Count > 0)
            {
                FillTextBoxes(employeeList[0]);
            }
        }
        private void FillTextBoxes(Employee employee)
        {
            // Verileri TextBox'lara yerleştir
            textBox1.Text = employee.EmployeeUsername;
            textBox2.Text = employee.EmployeePassword;
            textBox3.Text = employee.FirstName;
            textBox4.Text = employee.LastName;
            textBox5.Text = employee.Email;
            textBox6.Text = employee.Phone;
            textBox7.Text = employee.Salary.ToString();
        }
        private List<Employee> GetEmployeeDataFromDatabase()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT EmployeeUsername, EmployeePassword, FirstName, LastName, Email, Phone, Salary FROM Employee WHERE EmployeeUsername=@EmployeeUsername";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // @EmployeeUsername parametresine değeri atayın
                        command.Parameters.AddWithValue("@EmployeeUsername", KName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee
                                {
                                    EmployeeUsername = reader["EmployeeUsername"].ToString(),
                                    EmployeePassword = reader["EmployeePassword"].ToString(),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Salary = Convert.ToDecimal(reader["Salary"])
                                };

                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından veri alınırken bir hata oluştu: " + ex.Message);
            }

            return employees;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Güncellenecek verileri al
            string newPassword = textBox2.Text;
            string newEmail = textBox5.Text;
            string newPhone = textBox6.Text;

            // Güncelleme sorgusunu oluştur
            string updateQuery = "UPDATE Employee SET EmployeePassword = @NewPassword, Email = @NewEmail, Phone = @NewPhone";

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
                        // Sorguyu çalıştırın
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Veriler başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu.");
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
    public class Employee
    {
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
    }


}
