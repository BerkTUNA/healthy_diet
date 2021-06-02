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
    public partial class ana_sayfa : Form
    {
        public string isim;
        public ana_sayfa()
        {
            InitializeComponent();
            
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        DataTable tablo = new DataTable();
        
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Giris giris_say = new Giris();
            giris_say.Show();
            
            this.Hide();
        }
        private void listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select *from Hastalar", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void yeni_btn_Click(object sender, EventArgs e)
        {
            ekle_hasta ekle = new ekle_hasta();
            ekle.Show();
            this.Hide();
        }

        private void rapor_btn_Click(object sender, EventArgs e)
        {
            rapor rapor_al = new rapor();
            rapor_al.Show();
            this.Hide();
        }

        private void diyet_btn_Click(object sender, EventArgs e)
        {
            diyet_ata diyet = new diyet_ata();
            diyet.ad = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            diyet.soyad= dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            diyet.tc = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            diyet.Show();
            this.Hide();
        }

        private void hastalık_btn_Click(object sender, EventArgs e)
        {
            ekle_hastalık ekle = new ekle_hastalık();
            ekle.ShowDialog();
        }

        private void diyet_planı_Click(object sender, EventArgs e)
        {
            ekle_diyet ekle = new ekle_diyet();
            ekle.ShowDialog();
        }

        private void giriscks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ana_sayfa_Load(object sender, EventArgs e)
        {
           
            label9.Text = isim;
            listeleme();
        }
    }
}
