using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tasarım_Mimarisi
{
    public partial class admin_paneli : Form
    {
        public admin_paneli()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Giris giris_sayfasi = new Giris();
            giris_sayfasi.Show();
            this.Hide();
        }
        private void listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select * from Diyetisyenler,Hastalar", baglanti);
            liste.Fill(tablo);
            dataGridView2.DataSource = tablo;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Red;


            baglanti.Close();
        }
        private void hasta_btn_Click(object sender, EventArgs e)
        {
            hastalar hasta_liste = new hastalar();
            hasta_liste.Show();
            this.Hide();
        }

        private void diyetis_btn_Click(object sender, EventArgs e)
        {
            diyetisyenler diyetis_liste = new diyetisyenler();
            diyetis_liste.Show();
            this.Hide();
        }

        private void adminpcks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void admin_paneli_Load(object sender, EventArgs e)
        {
            listeleme();
        }
    }
}
