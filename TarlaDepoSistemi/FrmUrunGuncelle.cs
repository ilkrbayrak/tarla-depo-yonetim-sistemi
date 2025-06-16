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
using TarlaDepoSistemi.Database; // DbConnection'ın olduğu namespace!


namespace TarlaDepoSistemi
{
    public partial class FrmUrunGuncelle : Form
    {
        int urunID;

        public FrmUrunGuncelle(int id, string urunAdi, int urunTuruID, int saklamaSuresi)
        {
            InitializeComponent();
            urunID = id;
            txtUrunAdi.Text = urunAdi;
            txtSaklamaSuresi.Text = saklamaSuresi.ToString();

            // ComboBox doldurma kodunu buraya yaz
            // Sonra ComboBox'ta ilgili ürünü seçili yap:
            // foreach ile itemları gezip, value'su urunTuruID olanı seç:
            foreach (ComboboxItem item in cmbUrunTuru.Items)
            {
                if ((int)item.Value == urunTuruID)
                {
                    cmbUrunTuru.SelectedItem = item;
                    break;
                }
            }
        }
        public FrmUrunGuncelle()
        {
            InitializeComponent();
        }

        private void FrmUrunGuncelle_Load(object sender, EventArgs e)
        {
            cmbUrunTuru.Items.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Güncelle butonuna tıklandığında:
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Urunler SET UrunAdi=@adi, UrunTuruID=@turid, SaklamaSuresi=@sure WHERE UrunID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@turid", ((ComboboxItem)cmbUrunTuru.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@sure", int.Parse(txtSaklamaSuresi.Text));
                cmd.Parameters.AddWithValue("@id", urunID);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Ürün güncellendi!");
            this.Close();

        }
    }
}
