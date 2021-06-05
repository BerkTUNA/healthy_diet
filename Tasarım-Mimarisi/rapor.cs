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
        public string TC;
        public rapor()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        DataTable tablo = new DataTable();
        private readonly string _json= $"C:\\Users\\omerk\\Desktop\\Tasarım-Mimarisi\\Rapor.json";
        
        
        private void geri_btn_Click(object sender, EventArgs e)
        {
            
        }
        private void listele()
        {
            
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select *from Hastalar where TC ='"+TC+"'",baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;
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
            Sınfa_ekle(secili_hasta);
            try
            {
                
                var hasta_rapor = JsonConvert.SerializeObject(secili_hasta,Formatting.Indented);
                using (var yazdir = new StreamWriter(_json))
                {
                    yazdir.Write(hasta_rapor);
                    
                }
            }
            catch (Exception ex)
            {

                
            }
        }
        private void rapor_btn_Click(object sender, EventArgs e)
        {

            hasta_rapor();
        }
    }
}
