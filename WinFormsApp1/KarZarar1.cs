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

namespace WinFormsApp1
{
    public partial class KarZarar1 : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

        public KarZarar1()
        {
            InitializeComponent();
        }

        private bool karZararLoaded = false;

        private void KarZarar_Load(object sender, EventArgs e)
        {
            // Eğer form daha önce yüklenmişse tekrar yükleme
            if (karZararLoaded)
            {
                return;
            }

            // ComboBox'a yılları ekleyin
            for (int year = DateTime.Now.Year; year >= 2000; year--)
            {
                comboBox2.Items.Add(year.ToString());
            }

            // ComboBox1'e ayları ekleyin
            comboBox1.Items.Add("Bütün Aylar"); // Bütün Aylar'ı ekleyin

            string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames;

            for (int month = 1; month <= 12; month++)
            {
                comboBox1.Items.Add(monthNames[month - 1]);
            }

            // ComboBox1'de "Bütün Aylar"ı seçili hale getirin
            comboBox1.SelectedIndex = 0;

            // DataGridView için kolonları belirleyin
            dataGridView1.Columns.Add("OrderDate", "Sipariş Tarihi");
            dataGridView1.Columns.Add("TotalPrice", "Toplam Fiyat");
            dataGridView1.Columns.Add("OrderHistoryID", "Sipariş ID");

            // Zaten var olan "Seç" butonunun Click olayına "btnSelect_Click" metodunu bağla
            button1.Click += btnSelect_Click;

            // Form yüklendi olarak işaretle
            karZararLoaded = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Seçilen yılın verilerini DataGridView'e yükle
            LoadDataForSelectedYear();
            CalculateAndDisplaySecondTextBox();
        }

        private void LoadDataForSelectedYear()
        {
            // Önce DataGridView'i temizle
            dataGridView1.Rows.Clear();

            // Ardından TextBox'ları temizle
            textBox1.Text = "0";

            string selectedYear = comboBox2.SelectedItem as string;
            int selectedMonthIndex = comboBox1.SelectedIndex;

            // Seçilen yıl varsa işlemi gerçekleştir
            if (selectedYear != null)
            {
                string query;

                // Eğer "Bütün Aylar" seçiliyse, tüm aylara ait verileri getir
                if (selectedMonthIndex == 0)
                {
                    query = $@"
                SELECT 
                    OrderDate, 
                    TotalPrice, 
                    OrderHistoryID
                FROM 
                    OrderHistory
                WHERE 
                    YEAR(OrderDate) = {selectedYear}";
                }
                // Belirli bir ay seçiliyse, sadece o aya ait verileri getir
                else
                {
                    query = $@"
                SELECT 
                    OrderDate, 
                    TotalPrice, 
                    OrderHistoryID
                FROM 
                    OrderHistory
                WHERE 
                    YEAR(OrderDate) = {selectedYear} AND
                    MONTH(OrderDate) = {selectedMonthIndex}";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);

                        // DataGridView'e verileri ekle
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dataGridView1.Rows.Add(row["OrderDate"], row["TotalPrice"], row["OrderHistoryID"]);
                        }

                        // TextBox'ları sıfırla
                        if (dataTable.Rows.Count > 0)
                        {
                            decimal totalPriceSum = 0;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                totalPriceSum += Convert.ToDecimal(row["TotalPrice"]);
                            }
                            textBox1.Text = totalPriceSum.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri çekme sırasında bir hata oluştu: {ex.Message}");
                    }
                }
            }
        }
        private void CalculateTotalPriceForSelectedMounth()
        {
            string selectedYear = comboBox2.SelectedItem as string;
            int selectedMonthIndex = comboBox1.SelectedIndex;

            if (selectedYear != null && selectedMonthIndex > 0)
            {
                MessageBox.Show("Başka bir ay secildi.");
                MessageBox.Show(selectedMonthIndex.ToString());
                // Aşağıdaki sorgu, seçilen yıl ve aydaki siparişleri getirecektir.
                string query = $@"
            SELECT 
                OrderDate, 
                TotalPrice, 
                OrderHistoryID
            FROM 
                OrderHistory
            WHERE 
                YEAR(OrderDate) = {selectedYear} AND
                MONTH(OrderDate) = {selectedMonthIndex}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        if (dataGridView1.Rows.Count <= 1)
                        {
                            MessageBox.Show("Data TAble boş");
                            textBox1.Text = "0";


                        }
                        decimal totalPriceSum = 0;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            totalPriceSum += Convert.ToDecimal(row["TotalPrice"]);
                        }
                        if (dataGridView1.Rows.Count > 1)
                        {
                            MessageBox.Show("Data TAble dolu");
                            textBox1.Text = totalPriceSum.ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri çekme sırasında bir hata oluştu: {ex.Message}");
                    }

                }
            }
        }
        private void CalculateTotalPriceForSelectedYear()
        {
            string selectedYear = comboBox2.SelectedItem as string;
            int selectedMonthIndex = comboBox1.SelectedIndex;



            if (selectedYear != null && selectedMonthIndex == 0)
            {
                string query = $@"
           SELECT 
                OrderDate, 
                TotalPrice, 
                OrderHistoryID
            FROM 
                OrderHistory
            WHERE 
                YEAR(OrderDate) = {selectedYear}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);

                        decimal totalPriceSum = 0;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            totalPriceSum += Convert.ToDecimal(row["TotalPrice"]);
                        }

                        textBox1.Text = totalPriceSum.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri çekme sırasında bir hata oluştu: {ex.Message}");
                    }
                }
            }


        }

        private void CalculateAndDisplaySecondTextBox()
        {
            try
            {
                decimal totalAmount = Convert.ToDecimal(textBox1.Text);
                decimal secondTextBoxValue = totalAmount * 0.3m; // Yüzde 30'u hesapla
                textBox2.Text = secondTextBoxValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hesaplama sırasında bir hata oluştu: {ex.Message}");
            }
        }
    }
}
