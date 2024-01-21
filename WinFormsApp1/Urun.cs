using ClosedXML.Excel;
using System;
using System.Collections;
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
    public partial class Urun : Form
    {
        // Veritabanı bağlantı dizesi
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        // DataTable'ları tanımla
        private DataTable categoriesTable;
        private DataTable productsTable;

        public Urun()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            // ComboBox ve DataGridView'leri doldur
            FillComboBox();
            FillDataGridView();
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

            // 'Ürünler' öğesini ekle
            DataRow newRow = categoriesTable.NewRow();
            newRow["CategoryName"] = "Ürünler";
            newRow["CategoryID"] = 0; // ya da uygun bir değer
            categoriesTable.Rows.InsertAt(newRow, 0);

            // ComboBox'a verileri ata
            comboBox1.DataSource = categoriesTable;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
        }

        public void FillDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query;

                if (comboBox1.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;

                    if (selectedRow["CategoryName"].ToString() == "Ürünler")
                    {
                        query = "SELECT * FROM Products";
                    }
                    else
                    {
                        // CategoryID sütunu var mı ve null değil mi kontrol et
                        if (selectedRow.Row.Table.Columns.Contains("CategoryID") && selectedRow["CategoryID"] != DBNull.Value)
                        {
                            int selectedCategoryId = Convert.ToInt32(selectedRow["CategoryID"]);
                            query = $"SELECT * FROM Products WHERE CategoryID = {selectedCategoryId}";
                        }
                        else
                        {
                            query = "SELECT * FROM Products";
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    productsTable = new DataTable();
                    adapter.Fill(productsTable);

                    dataGridView1.DataSource = productsTable;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem is DataRowView selectedRow)
                {
                    // CategoryID sütunu var mı ve null değil mi kontrol et
                    if (selectedRow.Row.Table.Columns.Contains("CategoryID") && selectedRow["CategoryID"] != DBNull.Value)
                    {
                        int selectedCategoryId;

                        // TryParse kullanarak güvenli bir şekilde dönüşüm yapın
                        if (int.TryParse(selectedRow["CategoryID"].ToString(), out selectedCategoryId))
                        {
                            // Diğer işlemler
                            FillDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Hata: Seçilen kategorinin CategoryID değeri geçersiz.");
                        }
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form pkayıt = new ÜrünEkle();
            pkayıt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanıcı bir satır seçti mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki verileri al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                string ProductName = selectedRow.Cells["ProductName"].Value.ToString();
                int CategoryID = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);
                string Price = selectedRow.Cells["Price"].Value.ToString();
                string StockQuantity = selectedRow.Cells["StockQuantity"].Value.ToString();


                // Diğer formu oluştur ve verileri ileterek göster
                ÜrünDüzenle otherForm = new ÜrünDüzenle(productID, ProductName, CategoryID, Price, StockQuantity);
                otherForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }


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

        private void buttonExp_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = GetYourData();
                            workbook.Worksheets.Add(dt, "Products");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Export Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
        }
    }
}
