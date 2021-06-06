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
using Newtonsoft.Json;
using System.IO;


namespace Tasarım_Mimarisi
{
    public partial class rapor : Form
    {
        public string isim;
        public string TC,Diyet;
        bool raporyazdirildi = true;
        public rapor()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris.baglanti_kur();
        DataTable tablok = new DataTable();
        DataTable tablod = new DataTable();

        private readonly string _json= $"C:\\Users\\Berk\\Desktop\\tasarım\\healthy_diet\\Rapor.json";

       
        private void listele()
        {
            tablok.Clear();
            baglanti.Open();
            OleDbDataAdapter listek = new OleDbDataAdapter("select *from Hastalar where TC ='"+TC+"'",baglanti);
            listek.Fill(tablok);
            KullaniciVerileri.DataSource = tablok;
            KullaniciVerileri.DefaultCellStyle.SelectionBackColor = Color.White;
            KullaniciVerileri.DefaultCellStyle.SelectionForeColor = Color.Green;
           

            tablod.Clear();
            OleDbDataAdapter listed = new OleDbDataAdapter("select *from Diyetler where DiyetAdi ='" + Diyet + "'", baglanti);
            listed.Fill(tablod);
            Diyetverileri.DataSource = tablod;
            Diyetverileri.DefaultCellStyle.SelectionBackColor = Color.White;
            Diyetverileri.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();



        }
        private void Sınfa_ekle(hasta hasta1)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Hastalar where TC = '"+TC+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                hasta1.TC = oku["TC"].ToString();
                hasta1.Ad = oku["Ad"].ToString();
                hasta1.Soyad = oku["Soyad"].ToString();
                hasta1.Telefon = oku["Telefon"].ToString();
                hasta1.Teshis = oku["Teshis"].ToString();
                hasta1.Diyet = oku["Diyet"].ToString();

            }

            baglanti.Close();

            
        }
        private void diyet_ekle(diyet diyet)
        {
            baglanti.Open();
            OleDbCommand diyetsorgu = new OleDbCommand("select *from Diyetler where DiyetAdi = '" + Diyet + "'", baglanti);
        OleDbDataReader diyetoku = diyetsorgu.ExecuteReader();
            while (diyetoku.Read())
            {
                diyet.Diyetadi = diyetoku["DiyetAdi"].ToString();
                diyet.Pazartesi = diyetoku["Pazartesi"].ToString();
                diyet.Sali = diyetoku["Salı"].ToString();
                diyet.Carsamba = diyetoku["Çarşamba"].ToString();
                diyet.Persembe = diyetoku["Perşembe"].ToString();
                diyet.Cuma = diyetoku["Cuma"].ToString();
                diyet.Cumartesi = diyetoku["Cumartesi"].ToString();
                diyet.Pazar = diyetoku["Pazar"].ToString();
            }

              baglanti.Close();


        }
        private void anasycks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.isim = isim;
            ana.Show();
            this.Hide();
        }
        
        private void rapor_Load(object sender, EventArgs e)
        {
            listele();
           
        }
        private void hasta_rapor()
        {
            
            hasta secili_hasta = new hasta();
            diyet secili_hastad = new diyet();
            Sınfa_ekle(secili_hasta);
            diyet_ekle(secili_hastad);

            
           
            if (sira.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Yazdırma Sırasını Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                raporyazdirildi = false;
            }

            else if (sira.SelectedIndex == 1)
            {
                try
                {
                    var hasta_rapor = JsonConvert.SerializeObject(secili_hasta, Formatting.Indented);
                    var hasta_rapord = JsonConvert.SerializeObject(secili_hastad, Formatting.Indented);
                    using (var yazdir = new StreamWriter(_json))
                    {
                        yazdir.Write("Diyet Bilgileri \n" + hasta_rapord + "\nHasta Bilgileri \n" + hasta_rapor);
                        raporyazdirildi = true;
                        MessageBox.Show("Rapor Başarılı Bir Şekilde Yazdırıldı", "Tamam", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {


                }
            }
            else

            {
                try
                {
                    var hasta_rapor = JsonConvert.SerializeObject(secili_hasta, Formatting.Indented);
                    var hasta_rapord = JsonConvert.SerializeObject(secili_hastad, Formatting.Indented);
                    using (var yazdir = new StreamWriter(_json))
                    {
                        yazdir.Write("Hasta Bilgileri \n" + hasta_rapor + "\n Diyet Bilgileri \n" + hasta_rapord);
                        raporyazdirildi = true;
                        MessageBox.Show("Rapor Başarılı Bir Şekilde Yazdırıldı", "Tamam", MessageBoxButtons.OK);
                    }

                    
                }
                catch (Exception ex)
                {


                }

            }

            
        }
        private void rapor_btn_Click(object sender, EventArgs e)
        {

            hasta_rapor();
        }
    }
}
