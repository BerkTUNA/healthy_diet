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
    public partial class diyetisyenler : Form
    {
        public diyetisyenler()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        DataTable tablo = new DataTable();

        private void listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select * from Diyetisyenler", baglanti);
            liste.Fill(tablo);
            dataGridView4.DataSource = tablo;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView4.DefaultCellStyle.SelectionForeColor = Color.Green;


            baglanti.Close();
        }
        private void geri_btn_Click(object sender, EventArgs e)
        {
            
        }

       

        private void ekle_diyetis_Click(object sender, EventArgs e)
        {
            ekle_diyetisyen ekle = new ekle_diyetisyen();
            ekle.Show();
            this.Hide();
        }

        private void diyetisyenler_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            admin_paneli admin_ana = new admin_paneli();
            admin_ana.Show();
            this.Hide();
        }

        private void adminpcks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
