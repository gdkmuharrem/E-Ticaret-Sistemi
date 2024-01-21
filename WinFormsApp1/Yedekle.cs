using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Yedekle : Form
    {
        public Yedekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıya kaydedilecek dosyanın konumunu seçtirme
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Yedekleme Dosyasını Kaydet",
                    Filter = "Yedek Dosyaları (*.bak)|*.bak",
                    FileName = "VeritabaniBackup.bak",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosya yolu
                    string yedekYolu = saveFileDialog.FileName;

                    // Veritabanını kullanımdan kaldır
                    KullanimdanKaldir();

                    // Veritabanı bağlantısı için connection string
                    string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=OnlineAlısveris;Integrated Security=True";

                    // Veritabanı bağlantısı oluştur
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Backup sorgusu
                        string backupQuery = $"BACKUP DATABASE [OnlineAlısveris] TO DISK='{yedekYolu}' WITH FORMAT";

                        // Backup işlemi için SqlCommand oluştur
                        using (SqlCommand command = new SqlCommand(backupQuery, connection))
                        {
                            // Backup işlemini gerçekleştir
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Veritabanı başarıyla yedeklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Yedek Dosyasını Seç",
                    Filter = "Yedek Dosyaları (*.bak)|*.bak",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    RestoreDirectory = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosya yolu
                    string yedekDosyaYolu = openFileDialog.FileName;

                    // Veritabanını kullanımdan kaldır
                    KullanimdanKaldir();

                    // Veritabanı bağlantısı için connection string
                    string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

                    // Veritabanı bağlantısı oluştur
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Restore sorgusu
                        string restoreQuery = $"USE master RESTORE DATABASE [OnlineAlısveris] FROM DISK='{yedekDosyaYolu}' WITH REPLACE";

                        // Restore işlemi için SqlCommand oluştur
                        using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                        {
                            // Restore işlemini gerçekleştir
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Veritabanı başarıyla restore edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KullanimdanKaldir()
        {
            // Veritabanını kullanımdan kaldır
            string kullanımdanKaldirQuery = "USE master ALTER DATABASE [OnlineAlısveris] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            string geriAlQuery = "USE master ALTER DATABASE [OnlineAlısveris] SET MULTI_USER";

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command1 = new SqlCommand(kullanımdanKaldirQuery, connection))
                {
                    command1.ExecuteNonQuery();
                }

                using (SqlCommand command2 = new SqlCommand(geriAlQuery, connection))
                {
                    command2.ExecuteNonQuery();
                }
            }
        }


    }
}
