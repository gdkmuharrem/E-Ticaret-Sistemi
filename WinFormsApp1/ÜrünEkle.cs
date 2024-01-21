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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using ExcelDataReader;
using ClosedXML.Excel;
using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
            FillComboBox();
        }
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        private DataTable categoriesTable;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & comboBox1.Text != "")
            {
                string ürün_adi = textBox1.Text;
                int categoryID = Convert.ToInt32(comboBox1.SelectedValue);
                string fiyat = textBox2.Text;
                string stok = textBox3.Text;

                string query = "INSERT INTO Products(Productname,CategoryID,Price,StockQuantity) VALUES(@ürün_adi, @categoryID, @fiyat, @stok)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ürün_adi", ürün_adi);
                        command.Parameters.AddWithValue("@categoryID", categoryID);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        command.Parameters.AddWithValue("@stok", stok);


                        int affectedRows = command.ExecuteNonQuery();

                        // Sonuçları gösterin.
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Yeni ürün başarıyla eklendi.");
                            Urun u = Application.OpenForms["Urun"] as Urun;
                            u.FillDataGridView();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ürün eklenemedi.");
                        }
                    }
                }
            }

        }
        private void FillComboBox()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Categories tablosundan verileri çek
            categoriesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CategoryID, CategoryName FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(categoriesTable);
            }

            // ComboBox'a verileri ata
            comboBox1.DataSource = categoriesTable;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Select an Excel file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Dosya seçildikten sonra yapılacak işlemleri buraya ekleyebilirsiniz
                LoadDataToDatabase(filePath);
            }
        }
        private void LoadDataToDatabase(string filePath)
        {
            try
            {
                using (XLWorkbook workBook = new XLWorkbook(filePath))
                {
                    IXLWorksheet workSheet = workBook.Worksheet(1);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Sütun isimleri
                        string[] columnNames = { "ProductName", "CategoryID", "Price", "StockQuantity" };

                        // Verileri oku ve veritabanına ekle
                        foreach (var row in workSheet.RowsUsed().Skip(1))
                        {
                            using (SqlCommand command = new SqlCommand("INSERT INTO Products (ProductName, CategoryID, Price, StockQuantity) VALUES (@ProductName, @CategoryID, @Price, @StockQuantity)", connection))
                            {
                                // Parametreleri ekleyin
                                for (int i = 0; i < columnNames.Length; i++)
                                {
                                    object cellValue = row.Cell(i + 1).Value;

                                    if (columnNames[i] == "Price")
                                    {
                                        if (cellValue != null && decimal.TryParse(cellValue.ToString(), out decimal priceValue))
                                        {
                                            command.Parameters.Add("@" + columnNames[i], SqlDbType.Decimal).Value = priceValue;
                                        }
                                        else
                                        {
                                            // Hata durumu
                                            MessageBox.Show($"Hata: {columnNames[i]} sütunu için geçerli bir fiyat değeri bulunamadı.");
                                            return;
                                        }
                                    }
                                    else if (columnNames[i] == "CategoryID" || columnNames[i] == "StockQuantity")
                                    {
                                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int intValue))
                                        {
                                            command.Parameters.Add("@" + columnNames[i], SqlDbType.Int).Value = intValue;
                                        }
                                        else
                                        {
                                            // Hata durumu
                                            MessageBox.Show($"Hata: {columnNames[i]} sütunu için geçerli bir tamsayı değeri bulunamadı.");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        // Diğer türler için doğrudan değeri kullanabilirsiniz.
                                        command.Parameters.Add("@" + columnNames[i], SqlDbType.NVarChar).Value = cellValue.ToString();
                                    }
                                }

                                // Sorguyu çalıştırın
                                command.ExecuteNonQuery();
                            }
                        }

                    }

                    MessageBox.Show("Veriler başarıyla veritabanına eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {

        }
        string query = "SELECT * FROM Products";
        private DataTable GetYourData()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Columns.Add("ProductID", typeof(int));
                        dt.Columns.Add("ProductName", typeof(string));
                        dt.Columns.Add("CategoryID", typeof(int));
                        dt.Columns.Add("Price", typeof(decimal));
                        dt.Columns.Add("StockQuantity", typeof(int));


                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                Convert.ToInt32(reader["ProductID"]),
                                reader["ProductName"].ToString(),
                                Convert.ToInt32(reader["CategoryID"]),
                                Convert.ToDecimal(reader["Price"]),
                                Convert.ToInt32(reader["StockQuantity"])
                            );
                        }
                    }
                }
            }


            return dt;
        }

        
    }
}
