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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TarlaDepoSistemi.Database;


namespace TarlaDepoSistemi
{
    public partial class FrmCiftciGuncelle : Form
    {
        int ciftciID;
        public FrmCiftciGuncelle(int id, string ad, string soyad, string telefon, string email)
        {
            InitializeComponent();
            ciftciID = id;
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtTelefon.Text = telefon;
            txtEmail.Text = email;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Ciftciler SET Ad = @ad, Soyad = @soyad, Telefon = @tel, Email = @mail WHERE CiftciID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", ciftciID);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Kayıt güncellendi!");
            this.Close();
        }
    }
}
