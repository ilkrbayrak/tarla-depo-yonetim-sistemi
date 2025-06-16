using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TarlaDepoSistemi.Database;



namespace TarlaDepoSistemi
{
    public partial class FrmDepoDetay : Form
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }
        public FrmDepoDetay()
        {
            InitializeComponent();
        }

        private void FrmDepoDetay_Load(object sender, EventArgs e)
        {
            CiftciYukle();
            UrunYukle();
            DepoYukle();
            cbIslemTuru.Items.AddRange(new string[] { "Giriş", "Çıkış" });

            ListeleDetaylar();
            StokHesapla();
        }
        private void CiftciYukle()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT CiftciID, CONCAT(Ad, ' ', Soyad) AS AdSoyad FROM ciftciler";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbCiftci.Items.Add(new ComboboxItem
                    {
                        Text = dr["AdSoyad"].ToString(),
                        Value = dr["CiftciID"]
                    });
                }
            }
        }
        private void UrunYukle()
        {
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
        private void TarlaYukle(int ciftciID)
        {
            cbTarla.Items.Clear();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT TarlaID, TarlaAdi FROM tarlalar WHERE CiftciID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ciftciID);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ComboboxItem item = new ComboboxItem
                    {
                        Text = dr["TarlaAdi"].ToString(),
                        Value = dr["TarlaID"]
                    };
                    cbTarla.Items.Add(item);
                }
            }

            if (cbTarla.Items.Count > 0)
                cbTarla.SelectedIndex = 0;
        }
        private void TarlaYukleTum()
        {
            cbTarla.Items.Clear();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT TarlaID, TarlaAdi FROM tarlalar";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ComboboxItem item = new ComboboxItem
                    {
                        Text = dr["TarlaAdi"].ToString(),
                        Value = dr["TarlaID"]
                    };
                    cbTarla.Items.Add(item);
                }
            }

            if (cbTarla.Items.Count > 0)
                cbTarla.SelectedIndex = 0;
        }

        private void DepoYukle()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepoID, DepoAdi FROM depolar";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbDepo.Items.Add(new ComboboxItem
                    {
                        Text = dr["DepoAdi"].ToString(),
                        Value = dr["DepoID"]
                    });
                }
            }
        }
        private void ListeleDetaylar()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
        SELECT 
            dd.DetayID,
            CONCAT(c.Ad, ' ', c.Soyad) AS Ciftci,
            u.UrunAdi,
            t.TarlaAdi,
            d.DepoAdi,
            dd.Miktar,
            dd.IslemTuru,
            dd.Tarih,
            u.SaklamaSuresi
        FROM depodetay dd
        JOIN ciftciler c ON dd.CiftciID = c.CiftciID
        JOIN urunler u ON dd.UrunID = u.UrunID
        JOIN tarlalar t ON dd.TarlaID = t.TarlaID
        JOIN depolar d ON dd.DepoID = d.DepoID
        ORDER BY dd.Tarih DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDepoDetay.DataSource = dt;
            }

            // 🔍 Süresi geçmiş ürünleri kontrol et ve renklendir
            foreach (DataGridViewRow row in dgvDepoDetay.Rows)
            {
                if (row.IsNewRow) continue; // son boş satırı atla

                var islemTuruCell = row.Cells["IslemTuru"];
                var tarihCell = row.Cells["Tarih"];
                var saklamaCell = row.Cells["SaklamaSuresi"];

                if (islemTuruCell?.Value == null || tarihCell?.Value == null || saklamaCell?.Value == null)
                    continue;

                if (islemTuruCell.Value.ToString() == "Giriş")
                {
                    DateTime tarih = Convert.ToDateTime(tarihCell.Value);
                    int saklama = Convert.ToInt32(saklamaCell.Value);

                    if ((DateTime.Now - tarih).TotalDays > saklama)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // Geçmiş
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // Uygun
                    }
                }
                else if (islemTuruCell.Value.ToString() == "Çıkış")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void StokHesapla()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                u.UrunID,
                d.DepoID,
                u.UrunAdi,
                d.DepoAdi,
                ut.TuruAdi,
                SUM(CASE WHEN dd.IslemTuru = 'Giriş' THEN dd.Miktar ELSE 0 END) -
                SUM(CASE WHEN dd.IslemTuru = 'Çıkış' THEN dd.Miktar ELSE 0 END) AS Kalan
            FROM depodetay dd
            JOIN urunler u ON dd.UrunID = u.UrunID
            JOIN urunturleri ut ON u.UrunTuruID = ut.UrunTuruID
            JOIN depolar d ON dd.DepoID = d.DepoID
            GROUP BY u.UrunID, d.DepoID
            ORDER BY ut.TuruAdi, u.UrunAdi";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                string sonuc = "";
                while (dr.Read())
                {
                    int urunID = Convert.ToInt32(dr["UrunID"]);
                    int depoID = Convert.ToInt32(dr["DepoID"]);
                    bool gecikmis = RafOmruGectiMi(urunID, depoID);
                    string durum = gecikmis ? "⛔ Süresi Geçmiş" : "✅ Uygun";

                    sonuc += $"{dr["UrunAdi"]} ({dr["DepoAdi"]}): {dr["Kalan"]} adet | {durum}\n";
                }


                rtbStokDurumu.Text = sonuc;

            }
        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
    "CALL DepoIslemEkle(@ciftci, @urun, @tarla, @depo, @miktar, @islem, @tarih)", conn);


                    cmd.Parameters.AddWithValue("@ciftci", ((ComboboxItem)cbCiftci.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@urun", ((ComboboxItem)cbUrun.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@tarla", ((ComboboxItem)cbTarla.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@depo", ((ComboboxItem)cbDepo.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@miktar", nudMiktar.Value);
                    cmd.Parameters.AddWithValue("@islem", cbIslemTuru.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tarih", dtpTarih.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ürün işlemi başarıyla kaydedildi.");
                ListeleDetaylar();
                StokHesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
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

            return (mevcutStok + yeniGiris <= depoKapasite);
        }
        private bool RafOmruGectiMi(int urunID, int depoID)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                // 1. Son giriş tarihi
                string tarihQuery = @"
            SELECT MAX(Tarih)
            FROM depodetay
            WHERE UrunID = @urunID AND DepoID = @depoID AND IslemTuru = 'Giriş'";
                MySqlCommand tarihCmd = new MySqlCommand(tarihQuery, conn);
                tarihCmd.Parameters.AddWithValue("@urunID", urunID);
                tarihCmd.Parameters.AddWithValue("@depoID", depoID);
                object result = tarihCmd.ExecuteScalar();

                if (result == DBNull.Value) return false; // hiç giriş yoksa geçmiş sayma

                DateTime girisTarihi = Convert.ToDateTime(result);

                // 2. Saklama süresi
                string omurQuery = "SELECT SaklamaSuresi FROM urunler WHERE UrunID = @urunID";
                MySqlCommand omurCmd = new MySqlCommand(omurQuery, conn);
                omurCmd.Parameters.AddWithValue("@urunID", urunID);
                int saklamaSuresi = Convert.ToInt32(omurCmd.ExecuteScalar());

                // 3. Bugünün tarihiyle karşılaştır
                return (DateTime.Now - girisTarihi).TotalDays > saklamaSuresi;
            }
        }

        private void lblStokDurumu_Click(object sender, EventArgs e)
        {

        }

        private void rtbStokDurumu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCiftci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiftci.SelectedItem != null)
            {
                var secilen = (ComboboxItem)cbCiftci.SelectedItem;
                int ciftciID = Convert.ToInt32(secilen.Value);

                TarlaYukle(ciftciID);  // sadece bu çiftçiye ait tarlaları yükle
            }
        }

        private void cbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIslemTuru.SelectedItem == null) return;

            string secim = cbIslemTuru.SelectedItem.ToString();

            if (secim == "Giriş")
            {
                if (cbCiftci.SelectedItem != null)
                {
                    ComboboxItem secilen = (ComboboxItem)cbCiftci.SelectedItem;
                    int ciftciID = Convert.ToInt32(secilen.Value);
                    TarlaYukle(ciftciID);
                }
            }
            else if (secim == "Çıkış")
            {
                TarlaYukleTum(); // tüm tarlaları göster
            }
        }
    }
}
