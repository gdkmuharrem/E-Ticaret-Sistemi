using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp1
{
    public partial class MusteriSepet : Form
    {
        string adetValue;
        DataTable dt;
        string KullaniciAdi;
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";
        MusteriGiris mstrGrs = Application.OpenForms["MusteriGiris"] as MusteriGiris;
        public MusteriSepet()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeDt();
        }
        public void KAd(string Kad)
        {
            KullaniciAdi = Kad;
        }
        private void InitializeDataGridView()
        {
            // DataGridView sütunlarını oluştur
            dataGridView1.Columns.Add("CategoryNameColumn", "CategoryName");
            dataGridView1.Columns.Add("ProductNameColumn", "ProductName");
            dataGridView1.Columns.Add("PriceColumn", "Price");
            dataGridView1.Columns.Add("AdetColumn", "Adet");
            dataGridView1.Columns.Add("ToplamTutarColumn", "ToplamTutar");
        }

        private void InitializeDt()
        {
            dt = new DataTable();
            dt.Columns.Add("CategoryNameColumn", typeof(string));
            dt.Columns.Add("ProductNameColumn", typeof(string));
            dt.Columns.Add("PriceColumn", typeof(decimal));  // Varsayılan olarak decimal tipini kullanabilirsiniz.
            dt.Columns.Add("AdetColumn", typeof(int));  // Varsayılan olarak int tipini kullanabilirsiniz.
            dt.Columns.Add("ToplamTutarColumn", typeof(decimal));  // Varsayılan olarak decimal tipini kullanabilirsiniz.
        }
        public void BilgiEkle(DataTable dt)
        {
            // DataGridView'ı temizle
            dataGridView1.Rows.Clear();

            // DataTable'daki her bir satırı kontrol ederek DataGridView'a ekle
            foreach (DataRow row in dt.Rows)
            {
                // Eğer aynı bilgiler zaten varsa ekleme
                if (!IsDataExists(row))
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
        }

        private bool IsDataExists(DataRow newRow)
        {
            // DataGridView'da her bir satırı kontrol et
            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {
                bool isMatch = true;

                // Her bir hücreyi kontrol et ve eğer değerler eşleşmiyorsa isMatch'i false yap
                for (int i = 0; i < newRow.ItemArray.Length; i++)
                {
                    if (!dataGridViewRow.Cells[i].Value.Equals(newRow.ItemArray[i]))
                    {
                        isMatch = false;
                        break;
                    }
                }

                // Eğer tüm hücreler eşleşiyorsa bu satır zaten var demektir
                if (isMatch)
                {
                    return true;
                }
            }

            // Eğer eşleşen bir satır bulunamazsa, bu veri yok demektir
            return false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satırın indeksini al
            int selectedRowIndex = e.RowIndex;

            // Eğer geçerli bir satır tıklandıysa devam et
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                // Tıklanan satırın "Ürün Adedi" değerini al
                adetValue = dataGridView1.Rows[selectedRowIndex].Cells["AdetColumn"].Value.ToString();

                // ComboBox'ta seçili değeri ayarla
                comboBox1.SelectedItem = adetValue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Visible == false)
            {
                comboBox1.Visible = true;
            }

            // ComboBox'ta seçili değeri al
            string yeniAdetValue = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(yeniAdetValue) && yeniAdetValue != adetValue)
            {
                // Seçilen satırın indeksini al
                int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                // Eğer geçerli bir satır tıklandıysa devam et
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
                {
                    // Adet değerini güncelle
                    dataGridView1.Rows[selectedRowIndex].Cells["AdetColumn"].Value = yeniAdetValue;
                    mstrGrs.dt.Rows[selectedRowIndex]["Adet"] = yeniAdetValue;
                    // Adet değerini int olarak al
                    if (int.TryParse(yeniAdetValue, out int adet))
                    {
                        // Fiyat değerini decimal olarak al
                        decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[selectedRowIndex].Cells["PriceColumn"].Value);

                        // ToplamTutar'ı hesapla ve güncelle
                        decimal toplamTutar = adet * fiyat;
                        dataGridView1.Rows[selectedRowIndex].Cells["ToplamTutarColumn"].Value = toplamTutar.ToString();
                        mstrGrs.dt.Rows[selectedRowIndex]["ToplamTutar"] = toplamTutar.ToString();
                        // Güncelleme işlemi tamamlandıktan sonra adetValue'i de güncelle
                        adetValue = yeniAdetValue;
                    }
                    else
                    {
                        // Hata durumunda kullanıcıya bilgi ver
                        MessageBox.Show("Geçerli bir adet değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Seçilen satırın indeksini al
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            // Eğer geçerli bir satır tıklandıysa devam et
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                // DataGridView'dan seçilen satırı kaldır
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
                mstrGrs.dt.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabloekle();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataRow row in dt.Rows)
                    {
                        // Her bir satır için ProductName'i al ve IDGetir fonksiyonunu çağır
                        string productName = row["ProductNameColumn"].ToString();
                        int productID = IDGetir(productName);

                        using (SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerUserName, ProductID, Quantity, OrderStatus, TotalPrice) VALUES (@CustomerUserName, @ProductID, @Quantity, @OrderStatus, @TotalPrice)", connection))
                        {
                            command.Parameters.AddWithValue("@CustomerUserName", KullaniciAdi);
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.Parameters.AddWithValue("@Quantity", row["AdetColumn"]);
                            command.Parameters.AddWithValue("@OrderStatus", "A");
                            command.Parameters.AddWithValue("@TotalPrice", row["ToplamTutarColumn"]);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Siparişiniz Başarı ile oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    dt.Rows.Clear();
                    MusteriGiris musteri = Application.OpenForms["MusteriGiris"] as MusteriGiris;
                    musteri.dt.Clear();
                    musteri.dt2.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına ekleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Veritabanına ekleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabloekle()
        {
            dt.Rows.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow newRow = dt.NewRow();

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow[i] = row.Cells[i].Value;
                    }

                    dt.Rows.Add(newRow);
                }
            }
        }

        private int IDGetir(string productName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT ProductID FROM Products WHERE ProductName = @ProductName", connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);

                        // ExecuteScalar, yalnızca bir tek bir değer döndüren sorgular için kullanılır.
                        // Bu durumda, ProductID değerini döndürecektir.
                        object result = command.ExecuteScalar();

                        // Eğer result null değilse ve bir int'e dönüştürülebiliyorsa, bu değeri döndür.
                        if (result != null && int.TryParse(result.ToString(), out int productID))
                        {
                            return productID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından veri getirme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Hata durumlarında veya ProductID bulunamadığında -1 değerini döndürebilirsiniz.
            return -1;
        }
    }
}
