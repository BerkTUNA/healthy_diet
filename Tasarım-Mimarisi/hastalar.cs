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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        DataTable tablo = new DataTable();
        private void listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select * from Hastalar", baglanti);
            liste.Fill(tablo);
            dataGridView3.DataSource = tablo;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.Blue;


            baglanti.Close();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            admin_paneli admin_ana = new admin_paneli();
            admin_ana.Show();
            this.Hide();
        }

        private void hastalar_Load(object sender, EventArgs e)
        {
            listeleme();
        }
    }
}
