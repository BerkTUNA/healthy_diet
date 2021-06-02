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
    public partial class ekle_hastalık : Form
    {
        
        public ekle_hastalık()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Hastaliklar(HastalikAdi) values('" + hastalik.Text + "')", baglanti);
            komut.ExecuteReader();
            baglanti.Close();
            MessageBox.Show("Hastalık Eklendi", "Tamam");
            this.Hide();
        }

        

        private void anasycks_Click(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.Show();
            this.Hide();
        }
    }
}
