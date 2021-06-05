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
        private void item_add()
        {
            comboBox1.Items.Clear();
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Hastaliklar", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["HastalikAdi"].ToString());
            }
            baglanti.Close();
        }
        private void listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select *from Hastalar", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;
            baglanti.Close();
        }
        private void filitre_listeleme(string hastalik)
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select *from Hastalar where Teshis= '"+hastalik+"'", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;
            baglanti.Close();
        }
        private void avatar()
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Diyetisyenler", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["Ad"].ToString() == isim)
                {
                    if (oku["Cinsiyet"].ToString()=="Erkek")
                    {
                        Erkek.Visible = true;
                        Kadin.Visible = false;
                    }
                    else
                    {
                        Kadin.Visible = true;
                        Erkek.Visible = false;
                    }
                }
            }
            baglanti.Close();
        }
        private void yeni_btn_Click(object sender, EventArgs e)
        {
            ekle_hasta ekle = new ekle_hasta();
            ekle.isim = isim;
            ekle.Show();
            this.Hide();
        }

        private void rapor_btn_Click(object sender, EventArgs e)
        {
            rapor rapor_al = new rapor();
            rapor_al.isim = isim;
            rapor_al.TC= dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            rapor_al.Diyet = dataGridView1.CurrentRow.Cells["Diyet"].Value.ToString();
            rapor_al.Show();
            this.Hide();
        }

        private void diyet_btn_Click(object sender, EventArgs e)
        {
            diyet_ata diyet = new diyet_ata();
            diyet.ad = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            diyet.soyad= dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            diyet.tc = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            diyet.isim = isim;
            diyet.Show();
            this.Hide();
        }

        private void hastalık_btn_Click(object sender, EventArgs e)
        {
            ekle_hastalık ekle = new ekle_hastalık();
            ekle.isim = isim;
            ekle.Show();
            this.Hide();
            

        }

        private void diyet_planı_Click(object sender, EventArgs e)
        {
            ekle_diyet ekle = new ekle_diyet();
            ekle.isim = isim;
            ekle.Show();
            this.Hide();
        }

        private void giriscks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ana_sayfa_Load(object sender, EventArgs e)
        {
            label9.Text = isim;
            listeleme();
            item_add();
            avatar();
        }
        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.SelectedIndex==i)
                {
                    filitre_listeleme(comboBox1.SelectedItem.ToString());
                }
            }
        }
    }
}
