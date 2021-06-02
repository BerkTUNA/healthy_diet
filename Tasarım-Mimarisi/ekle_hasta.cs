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

        private void ad_txt_Enter(object sender, EventArgs e)
        {
           
        }

        private void ad_txt_Leave(object sender, EventArgs e)
        {
            if (ad_txt.Text == "")
            {
                ad_txt.Text = "Ad";
                ad_txt.ForeColor = Color.Silver;

            }
        }

        private void soyad_txt_Enter(object sender, EventArgs e)
        {
            if (soyad_txt.Text == "Soyad")
            {
                soyad_txt.Text = "";
                soyad_txt.ForeColor = Color.Black;

            }
        }

        private void soyad_txt_Leave(object sender, EventArgs e)
        {
            if (soyad_txt.Text == "")
            {
                soyad_txt.Text = "Soyad";
                soyad_txt.ForeColor = Color.Silver;

            }
        }

        private void tc_txt_Enter(object sender, EventArgs e)
        {
            if (tc_txt.Text == "TC")
            {
                tc_txt.Text = "";
                tc_txt.ForeColor = Color.Black;

            }
        }

        private void tc_txt_Leave(object sender, EventArgs e)
        {
            if (tc_txt.Text == "")
            {
                tc_txt.Text = "TC";
                tc_txt.ForeColor = Color.Silver;

            }
        }

        private void telefon_txt_Enter(object sender, EventArgs e)
        {
            if (telefon_txt.Text == "Telefon")
            {
                telefon_txt.Text = "";
                telefon_txt.ForeColor = Color.Black;

            }
        }

        private void telefon_txt_Leave(object sender, EventArgs e)
        {
            if (telefon_txt.Text == "")
            {
                telefon_txt.Text = "Telefon";
                telefon_txt.ForeColor = Color.Silver;

            }
        }

        private void comboboxteshis_Enter(object sender, EventArgs e)
        {
            if (comboboxteshis.Text == "Teşhis Seçiniz")
            {
                comboboxteshis.Text = "";
                comboboxteshis.ForeColor = Color.Black;

            }
        }

        private void comboboxteshis_Leave(object sender, EventArgs e)
        {
            if (comboboxteshis.Text == "")
            {
                comboboxteshis.Text = "Teşhis Seçiniz";
                comboboxteshis.ForeColor = Color.Silver;

            }
        }
    }
}
