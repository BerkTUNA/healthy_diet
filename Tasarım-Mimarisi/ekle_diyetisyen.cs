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
    public partial class ekle_diyetisyen : Form
    {
        bool kayit_yapildi = true;
        bool kullanici_adi_yok = true;
        public ekle_diyetisyen()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris.baglanti_kur();
        private void geri_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            kayit_yapildi = true;
            kullanici_adi_yok = true;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    if (Controls[i].Text == "Ad" || Controls[i].Text == "Soyad" || Controls[i].Text == "Kullanıcı-Adı" || Controls[i].Text == "Parola" || Controls[i].Text == "TC" || Controls[i].Text == "E-mail" || Controls[i].Text == "Adres" || Controls[i].Text == "Telefon")
                    {
                        MessageBox.Show("Eksik Bilgi Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kayit_yapildi = false;
                        break;


                    }


                }

            }
            if (Cinsiyet.SelectedItem==null)
            {
                MessageBox.Show("Lütfen cinsiyet şeçimi yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kayit_yapildi = false;
            }
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Diyetisyenler", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (kullanici_txt.Text == oku["KullaniciAdi"].ToString())
                {
                    MessageBox.Show("Kullanici Adi Kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kullanici_adi_yok = false;
                    break;

                }
            }
            baglanti.Close();
            if (sifre2_txt.Text!=sifre_txt.Text)
            {

                MessageBox.Show("Sifreler aynı degil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();

            }
            else
            {
                if (kullanici_adi_yok && kayit_yapildi)
                {
                    ekle();
                }
            }
        }

        private void adminpcks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            diyetisyenler diyetis_lis = new diyetisyenler();
            diyetis_lis.Show();
            this.Hide();
        }
        private void ekle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Diyetisyenler(Ad,Soyad,Cinsiyet,Tc,KullaniciAdi,Sifre,SifreTekrar,ePosta) values('" + ad_txt.Text + "','" + soyad_txt.Text + "','" + Cinsiyet.SelectedItem.ToString() + "','" + tc_txt.Text + "','" + kullanici_txt.Text + "','" + sifre_txt.Text + "','" + sifre2_txt.Text + "','" + eposta_txt.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Diyetisyen Eklendi", "Tamam");
            diyetisyenler list = new diyetisyenler();
            list.Show();
            this.Hide();
        }

        private void ad_txt_Enter(object sender, EventArgs e)
        {
            if (ad_txt.Text == "Ad")
            {
                ad_txt.Text = "";
                ad_txt.ForeColor = Color.Black;

            }
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

        private void Cinsiyet_Enter(object sender, EventArgs e)
        {
            if (Cinsiyet.Text == "Cinsiyetinizi Seçiniz")
            {
                Cinsiyet.Text = "";
                Cinsiyet.ForeColor = Color.Black;

            }
        }

        private void Cinsiyet_Leave(object sender, EventArgs e)
        {
            if (Cinsiyet.Text == "")
            {
                Cinsiyet.Text = "Cinsiyetinizi Seçiniz";
                Cinsiyet.ForeColor = Color.Silver;

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

        private void kullanici_txt_Enter(object sender, EventArgs e)
        {
            if (kullanici_txt.Text == "Kullanıcı Adı")
            {
                kullanici_txt.Text = "";
                kullanici_txt.ForeColor = Color.Black;

            }
        }

        private void kullanici_txt_Leave(object sender, EventArgs e)
        {
            if (kullanici_txt.Text == "")
            {
                kullanici_txt.Text = "Kullanıcı Adı";
                kullanici_txt.ForeColor = Color.Silver;

            }
        }

        private void sifre_txt_Enter(object sender, EventArgs e)
        {
            if (sifre_txt.Text == "Parola")
            {
                sifre_txt.Text = "";
                sifre_txt.PasswordChar = '*';
                sifre_txt.ForeColor = Color.Black;

            }
        }
        char? passwordgiris = null;
        private void sifre_txt_Leave(object sender, EventArgs e)
        {
            if (sifre_txt.Text == "")
            {
                sifre_txt.Text = "Parola";
                sifre_txt.PasswordChar = Convert.ToChar(passwordgiris);

                sifre_txt.ForeColor = Color.Silver;

            }
        }

        private void eposta_txt_Enter(object sender, EventArgs e)
        {
            if (eposta_txt.Text == "ePosta")
            {
                eposta_txt.Text = "";
                eposta_txt.ForeColor = Color.Black;

            }
        }

        private void eposta_txt_Leave(object sender, EventArgs e)
        {
            if (eposta_txt.Text == "")
            {
                eposta_txt.Text = "ePosta";
                eposta_txt.ForeColor = Color.Silver;

            }
        }

        private void sifre2_txt_Enter(object sender, EventArgs e)
        {
            if (sifre2_txt.Text == "Parola Tekrar")
            {
                sifre2_txt.Text = "";
                sifre2_txt.PasswordChar = '*';
                sifre2_txt.ForeColor = Color.Black;

            }
        }
        char? passwordgiristekrar = null;
        private void sifre2_txt_Leave(object sender, EventArgs e)
        {
            if (sifre2_txt.Text == "")
            {
                sifre2_txt.Text = "Parola Tekrar";
                sifre2_txt.PasswordChar = Convert.ToChar(passwordgiristekrar);

                sifre2_txt.ForeColor = Color.Silver;

            }
        }

        private void ekle_diyetisyen_Load(object sender, EventArgs e)
        {

        }
    }
}
