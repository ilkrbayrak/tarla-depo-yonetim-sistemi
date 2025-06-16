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
    public partial class FrmDepo : Form
    {
        public FrmDepo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDepoEkle frm = new FrmDepoEkle();
            frm.ShowDialog();
            DepoListele();
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            DepoListele();
        }
        private void DepoListele()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM depolar";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDepolar.DataSource = dt;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDepolar.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["DepoID"].Value);
                string adi = dgvDepolar.CurrentRow.Cells["DepoAdi"].Value.ToString();
                int kapasite = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["Kapasite"].Value);
                string konum = dgvDepolar.CurrentRow.Cells["Konum"].Value.ToString();

                FrmDepoGuncelle frm = new FrmDepoGuncelle(id, adi, kapasite, konum);
                frm.ShowDialog();
                DepoListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvDepolar.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["DepoID"].Value);

                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM depolar WHERE DepoID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                DepoListele();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
