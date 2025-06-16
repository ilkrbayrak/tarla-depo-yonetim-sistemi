using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarlaDepoSistemi.Database;

namespace TarlaDepoSistemi
{
    public partial class FrmDepoTransfer : Form
    {
        public FrmDepoTransfer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmDepoTransfer_Load(object sender, EventArgs e)
        {
            DepoYukle(cbKaynakDepo);
            DepoYukle(cbHedefDepo);
            UrunYukle();
        }
        private void DepoYukle(ComboBox combo)
        {
            combo.Items.Clear();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepoID, DepoAdi FROM depolar";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    combo.Items.Add(new ComboboxItem
                    {
                        Text = dr["DepoAdi"].ToString(),
                        Value = dr["DepoID"]
                    });
                }
            }
        }
        private void UrunYukle()
        {
            cbUrun.Items.Clear();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT UrunID, UrunAdi FROM urunler";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbUrun.Items.Add(new ComboboxItem
                    {
                        Text = dr["UrunAdi"].ToString(),
                        Value = dr["UrunID"]
                    });
                }
            }
        }
        private void cbKaynakDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MevcutStokGoster();
        }

        private void cbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            MevcutStokGoster();
        }
        private void MevcutStokGoster()
        {
            if (cbKaynakDepo.SelectedItem == null || cbUrun.SelectedItem == null)
            {
                lblMevcutStok.Text = "Mevcut stok: -";
                return;
            }

            int depoID = (int)((ComboboxItem)cbKaynakDepo.SelectedItem).Value;
            int urunID = (int)((ComboboxItem)cbUrun.SelectedItem).Value;

            decimal stok = 0;

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                IFNULL(SUM(CASE WHEN IslemTuru = 'Giriş' THEN Miktar ELSE 0 END), 0) -
                IFNULL(SUM(CASE WHEN IslemTuru = 'Çıkış' THEN Miktar ELSE 0 END), 0) AS Kalan
            FROM depodetay
            WHERE DepoID = @depo AND UrunID = @urun";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@depo", depoID);
                cmd.Parameters.AddWithValue("@urun", urunID);

                stok = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            lblMevcutStok.Text = $"Mevcut stok: {stok}";
        }

        private void btnTransferEt_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (cbKaynakDepo.SelectedItem == null || cbHedefDepo.SelectedItem == null || cbUrun.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            int kaynakDepoID = (int)((ComboboxItem)cbKaynakDepo.SelectedItem).Value;
            int hedefDepoID = (int)((ComboboxItem)cbHedefDepo.SelectedItem).Value;
            int urunID = (int)((ComboboxItem)cbUrun.SelectedItem).Value;
            decimal miktar = nudMiktar.Value;

            if (kaynakDepoID == hedefDepoID)
            {
                MessageBox.Show("Kaynak ve hedef depo aynı olamaz!");
                return;
            }

            // 1. Kaynaktaki stok yeterli mi?
            if (!KaynakYeterliMi(kaynakDepoID, urunID, miktar))
            {
                MessageBox.Show("Kaynak depoda yeterli stok yok!", "Yetersiz Stok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hedef kapasite uygun mu?
            if (!KapasiteUygunMu(hedefDepoID, urunID, miktar))
            {
                MessageBox.Show("Hedef depo kapasitesini aşamazsınız!", "Kapasite Aşıldı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. İşlemleri kaydet
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO depodetay (CiftciID, UrunID, TarlaID, DepoID, Miktar, IslemTuru, Tarih) 
                         VALUES (NULL, @urun, NULL, @depo, @miktar, @tur, @tarih)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Kaynak depodan çıkış
                cmd.Parameters.AddWithValue("@urun", urunID);
                cmd.Parameters.AddWithValue("@depo", kaynakDepoID);
                cmd.Parameters.AddWithValue("@miktar", miktar);
                cmd.Parameters.AddWithValue("@tur", "Çıkış");
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.ExecuteNonQuery();

                // Parametreleri sıfırla
                cmd.Parameters["@depo"].Value = hedefDepoID;
                cmd.Parameters["@tur"].Value = "Giriş";
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Transfer başarıyla gerçekleştirildi.");
            MevcutStokGoster(); // stok bilgisini güncelle
        }
        private bool KaynakYeterliMi(int depoID, int urunID, decimal miktar)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                IFNULL(SUM(CASE WHEN IslemTuru = 'Giriş' THEN Miktar ELSE 0 END), 0) -
                IFNULL(SUM(CASE WHEN IslemTuru = 'Çıkış' THEN Miktar ELSE 0 END), 0) AS Kalan
            FROM depodetay
            WHERE DepoID = @depo AND UrunID = @urun";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@depo", depoID);
                cmd.Parameters.AddWithValue("@urun", urunID);
                decimal kalan = Convert.ToDecimal(cmd.ExecuteScalar());
                return kalan >= miktar;
            }
        }
        private bool KapasiteUygunMu(int depoID, int urunID, decimal yeniGiris)
        {
            decimal mevcutStok = 0;
            decimal depoKapasite = 0;

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                // Mevcut Stok Hesapla
                string stokQuery = @"
            SELECT 
                IFNULL(SUM(CASE WHEN IslemTuru = 'Giriş' THEN Miktar ELSE 0 END), 0) -
                IFNULL(SUM(CASE WHEN IslemTuru = 'Çıkış' THEN Miktar ELSE 0 END), 0) AS Kalan
            FROM depodetay
            WHERE DepoID = @depoID AND UrunID = @urunID";

                MySqlCommand stokCmd = new MySqlCommand(stokQuery, conn);
                stokCmd.Parameters.AddWithValue("@depoID", depoID);
                stokCmd.Parameters.AddWithValue("@urunID", urunID);
                mevcutStok = Convert.ToDecimal(stokCmd.ExecuteScalar());

                // Kapasiteyi Al
                string kapasiteQuery = "SELECT Kapasite FROM depolar WHERE DepoID = @depoID";
                MySqlCommand kapasiteCmd = new MySqlCommand(kapasiteQuery, conn);
                kapasiteCmd.Parameters.AddWithValue("@depoID", depoID);
                depoKapasite = Convert.ToDecimal(kapasiteCmd.ExecuteScalar());
            }

            // Kontrol
            return (mevcutStok + yeniGiris <= depoKapasite);
        }
        private void GuncelleDepoStokBilgisi()
        {
            if (cbKaynakDepo.SelectedItem == null || cbUrun.SelectedItem == null)
                return;

            int depoID = Convert.ToInt32(((ComboboxItem)cbKaynakDepo.SelectedItem).Value);
            int urunID = Convert.ToInt32(((ComboboxItem)cbUrun.SelectedItem).Value);

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                IFNULL(SUM(CASE WHEN IslemTuru = 'Giriş' THEN Miktar ELSE 0 END), 0) -
                IFNULL(SUM(CASE WHEN IslemTuru = 'Çıkış' THEN Miktar ELSE 0 END), 0) AS Kalan
            FROM depodetay
            WHERE DepoID = @depoID AND UrunID = @urunID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@depoID", depoID);
                cmd.Parameters.AddWithValue("@urunID", urunID);

                object sonuc = cmd.ExecuteScalar();
                int kalan = Convert.ToInt32(sonuc);
                lblMevcutStok.Text = $"📦 Kaynak depoda mevcut: {kalan} adet";
            }
        }



        private void cbKaynakDepo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GuncelleDepoStokBilgisi();
        }

        private void cbUrun_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GuncelleDepoStokBilgisi();
        }
    }
}
