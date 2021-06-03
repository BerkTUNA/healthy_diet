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
    public partial class ekle_diyet : Form
    {
        public string isim;
        bool diyet_yok;
        public ekle_diyet()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            diyet_yok = true;
            if (diyet.Text == "")
            {
                MessageBox.Show("Lütfen Diyet ismini giriniz!", "Tamam");
            }
            else
            {
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select *from Diyetler", baglanti);
                OleDbDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    if (diyet.Text == oku["DiyetAdi"].ToString())
                    {
                        MessageBox.Show("Bu diyet zaten mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        diyet_yok = false;



                    }
                }
                baglanti.Close();
                if (diyet_yok)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Diyetler(DiyetAdi) values('" + diyet.Text + "')", baglanti);
                    komut.ExecuteReader();
                    baglanti.Close();
                    MessageBox.Show("Diyet Eklendi", "Tamam");
                    ana_sayfa ana = new ana_sayfa();
                    ana.isim = isim;
                    ana.Show();
                    this.Hide();
                }
            }
            


            
        }

        private void anasycks_Click(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.isim = isim;
            ana.Show();
            this.Hide();
        }

        private void diyet_Enter(object sender, EventArgs e)
        {
            
        }

        private void diyet_Leave(object sender, EventArgs e)
        {
            
        }

        private void ekle_diyet_Load(object sender, EventArgs e)
        {

        }
    }
}
