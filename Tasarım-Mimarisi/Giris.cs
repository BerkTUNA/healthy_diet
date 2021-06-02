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
    public partial class Giris : Form
    {
        bool giris_yapildi = false;
        
        public Giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        private void giris_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Diyetisyenler", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==kullanici.Text && oku["sifre"].ToString()==sifre.Text && oku["Yetki"].ToString()=="admin")
                {
                    giris_yapildi = true;
                    admin_paneli admin_ana = new admin_paneli();
                    admin_ana.Show();
                    this.Hide();

                }
                else if (oku["KullaniciAdi"].ToString() == kullanici.Text && oku["sifre"].ToString() == sifre.Text && oku["Yetki"].ToString() == "Diyetisyen")
                {
                    giris_yapildi = true;
                    ana_sayfa ana = new ana_sayfa();
                    ana.isim = oku["Ad"].ToString();
                    ana.Show();
                    this.Hide();
                }

            }
            if (kullanici.Text =="Kullanıcı-Adı" ||   sifre.Text == "Parola")
            {
                MessageBox.Show("Kullanici Adi veya şifre boş geçilmez", "Tamam");
            }
            else if (!giris_yapildi)
            {
                MessageBox.Show("Kullanici Adi veya sifre yanlis", "Tamam");
            }
            
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanici_Enter(object sender, EventArgs e)
        {
            if(kullanici.Text=="Kullanıcı-Adı")
            {
                kullanici.Text = "";
                kullanici.ForeColor = Color.Black;

            }
        }

        private void kullanici_Leave(object sender, EventArgs e)
        {
            if (kullanici.Text == "")
            {
                kullanici.Text = "Kullanıcı-Adı";
                kullanici.ForeColor = Color.Silver;

            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Parola")
            {
                sifre.Text = "";
                sifre.PasswordChar = '*';
                sifre.ForeColor = Color.Black;

            }
        }
        char? passwordgiris = null;
        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Parola";
                sifre.PasswordChar = Convert.ToChar(passwordgiris);

                sifre.ForeColor = Color.Silver;

            }
        }

        private void kullanici_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
