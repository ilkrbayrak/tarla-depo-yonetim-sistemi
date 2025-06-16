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


    public partial class FrmTarlaEkle : Form
    {
        private void FrmTarlaEkle_Load(object sender, EventArgs e)
        {
            cmbCiftci.Items.Clear();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT CiftciID, Ad, Soyad FROM Ciftciler", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Hem isim gözüksün hem ID tutulabilsin
                    cmbCiftci.Items.Add(new ComboboxItem
                    {
                        Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString(),
                        Value = dr["CiftciID"]
                    });
                }
                dr.Close();
            }
        }



        public FrmTarlaEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTarlaAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("CALL TarlaEkle(@adi, @konum, @ciftciID)", conn);
                    cmd.Parameters.AddWithValue("@adi", txtTarlaAdi.Text);
                    cmd.Parameters.AddWithValue("@konum", txtKonum.Text);
                    cmd.Parameters.AddWithValue("@ciftciID", ((ComboboxItem)cmbCiftci.SelectedItem).Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tarla başarıyla eklendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }

}
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }

