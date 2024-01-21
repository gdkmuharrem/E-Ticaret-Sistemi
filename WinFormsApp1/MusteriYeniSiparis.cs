using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp1
{
    public partial class MusteriYeniSiparis : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
        private DataTable categoriesTable;
        private DataTable productsTable;
        DataTable sepetVerileri;
        public MusteriYeniSiparis()
        {
            InitializeComponent();
            FillComboBox();
            sepetVerileri = new DataTable();
            comboBox3.SelectedIndex = -1;
            sepetVerileri.Columns.Add("CategoryName", typeof(string));
            sepetVerileri.Columns.Add("ProductName", typeof(string));
            sepetVerileri.Columns.Add("Price", typeof(decimal));
            sepetVerileri.Columns.Add("Adet", typeof(int));
            sepetVerileri.Columns.Add("ToplamTutar", typeof(decimal));
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            if (comboBox1.SelectedValue != null)
            {
                // Seçilen öğeyi DataRowView olarak al
                DataRowView selectedCategoryRow = (DataRowView)comboBox1.SelectedItem;

                // DataRowView'dan CategoryID değerini al
                int selectedCategoryId = Convert.ToInt32(selectedCategoryRow["CategoryID"]);

                string query = "SELECT ProductID, ProductName, Price FROM Products WHERE CategoryID = @SelectedCategoryID";
                productsTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                    command.Parameters.AddWithValue("@SelectedCategoryID", selectedCategoryId);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(productsTable);
                }

                // ComboBox'a verileri ata
                comboBox2.DataSource = productsTable;
                comboBox2.DisplayMember = "ProductName";
                comboBox2.ValueMember = "ProductID";
            }
        }
        decimal productPrice;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            if (comboBox2.SelectedValue != null)
            {
                DataRowView selectedProductRow = (DataRowView)comboBox2.SelectedItem;
                productPrice = Convert.ToDecimal(selectedProductRow["Price"]);
                textBox1.Text = productPrice.ToString("C");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal price = (comboBox3.SelectedIndex + 1) * productPrice;
            textBox2.Text = price.ToString();
        }
        private bool isButtonClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
                DataRowView selected2Row = (DataRowView)comboBox2.SelectedItem;

                int CategoryID = Convert.ToInt32(selectedRow["CategoryID"]);
                string CategoryName = selectedRow["CategoryName"].ToString();
                int ProductID = Convert.ToInt32(selected2Row["ProductID"]);
                string ProductName = selected2Row["ProductName"].ToString();
                decimal Price = productPrice;
                int Adet = (comboBox3.SelectedIndex + 1);
                decimal ToplamTutar = Convert.ToDecimal(textBox2.Text);

                DataRow newRow = sepetVerileri.NewRow();
                newRow["CategoryName"] = CategoryName;
                newRow["ProductName"] = ProductName;
                newRow["Price"] = Price;
                newRow["Adet"] = Adet;
                newRow["ToplamTutar"] = ToplamTutar;
                sepetVerileri.Rows.Add(newRow);
                MessageBox.Show("Ürün sepete eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MusteriYeniSiparis_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusteriGiris mstrGrs = Application.OpenForms["MusteriGiris"] as MusteriGiris;
            if (mstrGrs != null)
            {
                mstrGrs.MergeDataTableWithoutClear(mstrGrs.dt2, sepetVerileri);
            }
        }
    }
}
