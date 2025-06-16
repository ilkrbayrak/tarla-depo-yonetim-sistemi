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
    public partial class FrmCiftci : Form
    {
        public FrmCiftci()
        {
            InitializeComponent();
        }

        private void FrmCiftci_Load(object sender, EventArgs e)
        {
            CiftciListele();
        }
        private void CiftciListele()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM ciftciler";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCiftciler.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCiftciEkle frm = new FrmCiftciEkle();
            frm.ShowDialog();
            CiftciListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvCiftciler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCiftciler.CurrentRow.Cells["CiftciID"].Value);
                string ad = dgvCiftciler.CurrentRow.Cells["Ad"].Value.ToString();
                string soyad = dgvCiftciler.CurrentRow.Cells["Soyad"].Value.ToString();
                string telefon = dgvCiftciler.CurrentRow.Cells["Telefon"].Value.ToString();
                string email = dgvCiftciler.CurrentRow.Cells["Email"].Value.ToString();

                FrmCiftciGuncelle frm = new FrmCiftciGuncelle(id, ad, soyad, telefon, email);
                frm.ShowDialog();
                CiftciListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvCiftciler.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dgvCiftciler.SelectedRows[0].Cells["CiftciID"].Value);

                DialogResult sonuc = MessageBox.Show(
                    "Bu çiftçiyi silersen ona bağlı tüm tarlalar da silinecek.\nDevam etmek istiyor musun?",
                    "Dikkat!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    using (MySqlConnection conn = DbConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM ciftciler WHERE CiftciID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", secilenID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Çiftçi ve ilişkili tarlalar başarıyla silindi.");
                    CiftciListele(); // listeyi güncelle
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir çiftçi seçiniz.");
            }
            if (dgvCiftciler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCiftciler.CurrentRow.Cells["CiftciID"].Value);

                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM ciftciler WHERE CiftciID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                CiftciListele();
            }

        }
    }
}
