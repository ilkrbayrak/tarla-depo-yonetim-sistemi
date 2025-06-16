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
    public partial class FrmTarlalar : Form
    {
        private void TarlalariListele()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT TarlaID, TarlaAdi, Konum, CiftciID FROM Tarlalar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTarlalar.DataSource = dt;
            }
        }

        public FrmTarlalar()
        {
            InitializeComponent();
        }

        private void FrmTarlalar_Load(object sender, EventArgs e)
        {
            TarlalariListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmTarlaEkle frm = new FrmTarlaEkle();
            frm.ShowDialog();
            TarlalariListele(); // Yenile
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvTarlalar.SelectedRows.Count > 0)
            {
                int tarlaID = Convert.ToInt32(dgvTarlalar.SelectedRows[0].Cells["TarlaID"].Value);

                DialogResult result = MessageBox.Show("Seçili tarlayı silmek istediğine emin misin?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = DbConnection.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM Tarlalar WHERE TarlaID = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", tarlaID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Tarla silindi!");
                    TarlalariListele(); // Listeyi yenile
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir tarla seç!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvTarlalar.SelectedRows.Count > 0)
            {
                int tarlaID = Convert.ToInt32(dgvTarlalar.SelectedRows[0].Cells["TarlaID"].Value);
                string tarlaAdi = dgvTarlalar.SelectedRows[0].Cells["TarlaAdi"].Value.ToString();
                string konum = dgvTarlalar.SelectedRows[0].Cells["Konum"].Value.ToString();
                int ciftciID = Convert.ToInt32(dgvTarlalar.SelectedRows[0].Cells["CiftciID"].Value);

                FrmTarlaGuncelle frm = new FrmTarlaGuncelle(tarlaID, tarlaAdi, konum, ciftciID);
                frm.ShowDialog();
                TarlalariListele(); // Güncellemeden sonra yenile
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir tarla seç!");
            }
        }
    }
}
