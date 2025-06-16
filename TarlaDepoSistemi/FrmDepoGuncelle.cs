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
    public partial class FrmDepoGuncelle : Form
    {
        private int depoID;
        public FrmDepoGuncelle(int id, string adi, int kapasite, string konum)
        {
            InitializeComponent();
            depoID = id;
            txtDepoAdi.Text = adi;
            nudKapasite.Value = kapasite;
            txtKonum.Text = konum;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE depolar SET DepoAdi = @adi, Kapasite = @kapasite, Konum = @konum WHERE DepoID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adi", txtDepoAdi.Text);
                cmd.Parameters.AddWithValue("@kapasite", nudKapasite.Value);
                cmd.Parameters.AddWithValue("@konum", txtKonum.Text);
                cmd.Parameters.AddWithValue("@id", depoID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Depo bilgileri güncellendi.");
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
