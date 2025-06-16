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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        private void UrunleriListele()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT UrunID, UrunAdi, UrunTuruID, SaklamaSuresi FROM Urunler", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunleriListele();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunEkle frm = new FrmUrunEkle();
            frm.ShowDialog();
            UrunleriListele(); // Ekleme sonrası listeyi yenile
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin!");
                return;
            }

            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);

            var cevap = MessageBox.Show("Silmek istediğine emin misin?", "Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Urunler WHERE UrunID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", urunID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ürün silindi!");
                UrunleriListele(); // Yeniden listele
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçiniz!");
                return;
            }

            // Seçili satırdaki verileri al
            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
            string urunAdi = dgvUrunler.SelectedRows[0].Cells["UrunAdi"].Value.ToString();
            int urunTuruID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunTuruID"].Value);
            int saklamaSuresi = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["SaklamaSuresi"].Value);

            // Güncelleme formunu aç ve seçili ürünü aktar
            FrmUrunGuncelle frm = new FrmUrunGuncelle(urunID, urunAdi, urunTuruID, saklamaSuresi);
            frm.ShowDialog();

            // Güncellemeden sonra listeyi yenile
            UrunleriListele();
        }
    }
}
