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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            cmbUrunTuru.Items.Clear();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT UrunTuruID, TuruAdi FROM UrunTurleri", conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbUrunTuru.Items.Add(new ComboboxItem
                    {
                        Text = dr["TuruAdi"].ToString(), // ← burada da TuruAdi olacak
                        Value = dr["UrunTuruID"]
                    });
                }
                dr.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSaklamaSuresi.Text) ||
                cmbUrunTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UrunEkle", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pUrunAdi", txtUrunAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@pUrunTuruID", ((ComboboxItem)cmbUrunTuru.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@pSaklamaSuresi", Convert.ToInt32(txtSaklamaSuresi.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla eklendi.");

                    // Temizle
                    txtUrunAdi.Clear();
                    txtSaklamaSuresi.Clear();
                    cmbUrunTuru.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


        private void cmbUrunTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT UrunTuruID, TuruAdi FROM UrunTurleri", conn);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbUrunTuru.Items.Add(new ComboboxItem
                        {
                            Text = dr["TuruAdi"].ToString(),
                            Value = dr["UrunTuruID"]
                        });
                    }
                }
            }


        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        private void txtSaklamaSuresi_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
