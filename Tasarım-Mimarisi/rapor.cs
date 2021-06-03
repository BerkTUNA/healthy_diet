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
    public partial class rapor : Form
    {
        public string isim;
        public rapor()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            
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

        }
    }
}
