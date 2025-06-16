using MySql.Data.MySqlClient;
using TarlaDepoSistemi.Database;
using System.Data;
using TarlaDepoSistemi;

namespace TarlaDepoSistemi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarlalar_Click(object sender, EventArgs e)
        {
            FrmTarlalar frm = new FrmTarlalar();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTarlalar frm = new FrmTarlalar();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCiftci frm = new FrmCiftci();
            frm.ShowDialog();
        }

        private void btnDepolar_Click(object sender, EventArgs e)
        {
            FrmDepo frm = new FrmDepo();
            frm.ShowDialog();
        }

        private void btnDepoDetay_Click(object sender, EventArgs e)
        {
            FrmDepoDetay frm = new FrmDepoDetay();
            frm.ShowDialog();
        }

        private void btnDepoTransfer_Click(object sender, EventArgs e)
        {
            FrmDepoTransfer frm = new FrmDepoTransfer();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
