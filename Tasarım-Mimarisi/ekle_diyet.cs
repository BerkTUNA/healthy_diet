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
        OleDbConnection baglanti = Giris.baglanti_kur();
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            diyet_yok = true;
            if (diyetadi.Text == "Diyet Adı" || pzt.Text == "Pazartesi" || sli.Text == "Salı" || crsb.Text == "Çarşamba" || prsb.Text == "Perşembe" || cma.Text == "Cuma" || cmts.Text == "Cumartesi" ||  pzr.Text == "Pazar")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select *from Diyetler", baglanti);
                OleDbDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    if (diyetadi.Text == oku["DiyetAdi"].ToString())
                    {
                        MessageBox.Show("Bu diyet zaten mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        diyet_yok = false;



                    }
                }
                baglanti.Close();
                if (diyet_yok)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Diyetler(DiyetAdi,Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar) values('" + diyetadi.Text + "','" +pzt.Text+ "','"+sli.Text+ "','"+crsb.Text+ "','"+prsb.Text+ "','"+cma.Text+ "','"+cmts.Text+ "','"+pzr.Text+"')", baglanti);
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
            if (diyetadi.Text == "Diyet Adı")
            {
                diyetadi.Text = "";
                diyetadi.ForeColor = Color.Black;

            }
        }

        private void diyet_Leave(object sender, EventArgs e)
        {
            if (diyetadi.Text == "")
            {
                diyetadi.Text = "Diyet Adı";
                diyetadi.ForeColor = Color.Silver;

            }
        }

        private void ekle_diyet_Load(object sender, EventArgs e)
        {
           
        }

        private void pzt_Enter(object sender, EventArgs e)
        {
            if (pzt.Text == "Pazartesi")
            {
                pzt.Text = "";
                pzt.ForeColor = Color.Black;

            }
        }

        private void pzt_Leave(object sender, EventArgs e)
        {
            if (pzt.Text == "")
            {
                pzt.Text = "Pazartesi";
                pzt.ForeColor = Color.Silver;

            }
        }

        private void sli_Enter(object sender, EventArgs e)
        {
            if (sli.Text == "Salı")
            {
                sli.Text = "";
                sli.ForeColor = Color.Black;

            }
        }

        private void sli_Leave(object sender, EventArgs e)
        {
            if (sli.Text == "")
            {
                sli.Text = "Salı";
                sli.ForeColor = Color.Silver;

            }
        }

        private void crsb_Enter(object sender, EventArgs e)
        {
            if (crsb.Text == "Çarşamba")
            {
                crsb.Text = "";
                crsb.ForeColor = Color.Black;

            }
        }

        private void crsb_Leave(object sender, EventArgs e)
        {
            if (crsb.Text == "")
            {
                crsb.Text = "Çarşamba";
                crsb.ForeColor = Color.Silver;

            }
        }

        private void prsb_Enter(object sender, EventArgs e)
        {
            if (prsb.Text == "Perşembe")
            {
                prsb.Text = "";
                prsb.ForeColor = Color.Black;

            }
        }

        private void prsb_Leave(object sender, EventArgs e)
        {
            if (prsb.Text == "")
            {
                prsb.Text = "Perşembe";
                prsb.ForeColor = Color.Silver;

            }
        }

        private void cma_Enter(object sender, EventArgs e)
        {
            if (cma.Text == "Cuma")
            {
                cma.Text = "";
                cma.ForeColor = Color.Black;

            }
        }

        private void cma_Leave(object sender, EventArgs e)
        {
            if (cma.Text == "")
            {
                cma.Text = "Cuma";
                cma.ForeColor = Color.Silver;

            }
        }

        private void cmts_Enter(object sender, EventArgs e)
        {
            if (cmts.Text == "Cumartesi")
            {
                cmts.Text = "";
                cmts.ForeColor = Color.Black;

            }
        }

        private void cmts_Leave(object sender, EventArgs e)
        {
            if (cmts.Text == "")
            {
                cmts.Text = "Cumartesi";
                cmts.ForeColor = Color.Silver;

            }
        }

        private void pzr_Enter(object sender, EventArgs e)
        {
            if (pzr.Text == "Pazar")
            {
                pzr.Text = "";
                pzr.ForeColor = Color.Black;

            }
        }

        private void pzr_Leave(object sender, EventArgs e)
        {
            if (pzr.Text == "")
            {
                pzr.Text = "Pazar";
                pzr.ForeColor = Color.Silver;

            }
        }
    }
}
