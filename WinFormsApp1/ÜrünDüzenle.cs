using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class ÜrünDüzenle : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
        private DataTable categoriesTable;
        public ÜrünDüzenle(string productID, string ProductName, int CategoryID, string Price, string StockQuantity)
        {
            InitializeComponent();

            FillComboBox();

            label1.Text = productID;
            textBox1.Text = ProductName;
            comboBox1.SelectedValue = CategoryID;
            textBox2.Text = Price;
            textBox3.Text = StockQuantity;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" & textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & comboBox1.Text != "")
            {
                int productID = Convert.ToInt32(label1.Text);
                string ürün_adi = textBox1.Text;
                int categoryID = Convert.ToInt32(comboBox1.SelectedValue);
                decimal fiyat = Convert.ToDecimal(textBox2.Text);
                int stok = Convert.ToInt32(textBox3.Text);
                


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@productID", productID);
                        command.Parameters.AddWithValue("@ürün_adi", ürün_adi);
                        command.Parameters.AddWithValue("@categoryID", categoryID);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        command.Parameters.AddWithValue("@stok", stok);


                        int affectedRows = command.ExecuteNonQuery();

                        // Sonuçları gösterin.
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Ürün başarıyla güncellendi.");
                            Urun urn = Application.OpenForms["Urun"] as Urun;
                            urn.FillDataGridView();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ürün güncellenemedi.");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
