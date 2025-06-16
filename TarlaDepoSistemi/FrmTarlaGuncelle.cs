using Google.Protobuf.WellKnownTypes;
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

    public partial class FrmTarlaGuncelle : Form
    {
        int tarlaID;
        string tarlaAdi;
        string konum;
        int ciftciID;
        public FrmTarlaGuncelle(int _tarlaID, string _tarlaAdi, string _konum, int _ciftciID)
        {
            InitializeComponent();
            tarlaID = _tarlaID;
            txtTarlaAdi.Text = _tarlaAdi;
            txtKonum.Text = _konum;

            // ComboBox'a çiftçileri doldur
            cmbCiftci.Items.Clear();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT CiftciID, Ad, Soyad FROM Ciftciler", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ComboboxItem item = new ComboboxItem
                    {
                        Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString(),
                        Value = dr["CiftciID"]
                    };
                    cmbCiftci.Items.Add(item);
                    if ((int)dr["CiftciID"] == _ciftciID)
                        cmbCiftci.SelectedItem = item;
                }
                dr.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbCiftci.SelectedItem is ComboboxItem seciliCiftci)
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Tarlalar SET TarlaAdi=@adi, Konum=@konum, CiftciID=@ciftciid WHERE TarlaID=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@adi", txtTarlaAdi.Text);
                    cmd.Parameters.AddWithValue("@konum", txtKonum.Text);
                    cmd.Parameters.AddWithValue("@ciftciid", seciliCiftci.Value);
                    cmd.Parameters.AddWithValue("@id", tarlaID); // Bu yukarıda constructor ile atanmış olmalı!
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tarla güncellendi!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir çiftçi seç!");
            }
        }
    }
    
}
