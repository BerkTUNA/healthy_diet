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
    public partial class ekle_hasta : Form
    {
        
        public ekle_hasta()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        private void geri_btn_Click(object sender, EventArgs e)
        {
           

        }

        private void geri_btn_Click_1(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.Show();
            this.Hide();
        }
        private void item_add()
        {
            comboboxteshis.Items.Clear();
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Hastaliklar", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                comboboxteshis.Items.Add(oku["HastalikAdi"].ToString());
            }
            baglanti.Close();
        }

        private void anasycks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Hastalar(Ad,Soyad,TC,Telefon,Teshis) values('" + ad_txt.Text + "','" + soyad_txt.Text+ "','" + tc_txt.Text + "','" + telefon_txt.Text + "','" + comboboxteshis.SelectedItem.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta başarılı bir şekilde eklendi!", "Tamam");
        }

        private void ekle_hasta_Load(object sender, EventArgs e)
        {
            item_add();
        }
    }
}
