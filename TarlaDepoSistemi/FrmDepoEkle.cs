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
    public partial class FrmDepoEkle : Form
    {
        public FrmDepoEkle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmDepoEkle_Load(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO depolar (DepoAdi, Kapasite, Konum) VALUES (@adi, @kapasite, @konum)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adi", txtDepoAdi.Text);
                cmd.Parameters.AddWithValue("@kapasite", nudKapasite.Value);
                cmd.Parameters.AddWithValue("@konum", txtKonum.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Depo başarıyla eklendi.");
            this.Close();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO depolar (DepoAdi, Kapasite, Konum) VALUES (@adi, @kapasite, @konum)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adi", txtDepoAdi.Text);
                cmd.Parameters.AddWithValue("@kapasite", nudKapasite.Value);
                cmd.Parameters.AddWithValue("@konum", txtKonum.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Depo başarıyla eklendi.");
            this.Close();
        }
    }
}
