using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasarım_Mimarisi
{
    public partial class ekle_diyetisyen : Form
    {
        public ekle_diyetisyen()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

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
    }
}
