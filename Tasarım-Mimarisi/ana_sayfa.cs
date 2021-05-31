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
    public partial class ana_sayfa : Form
    {
        public ana_sayfa()
        {
            InitializeComponent();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Giris giris_say = new Giris();
            giris_say.Show();
            this.Hide();
        }

        private void yeni_btn_Click(object sender, EventArgs e)
        {
            ekle_hasta ekle = new ekle_hasta();
            ekle.Show();
            this.Hide();
        }

        private void rapor_btn_Click(object sender, EventArgs e)
        {
            rapor rapor_al = new rapor();
            rapor_al.Show();
            this.Hide();
        }

        private void diyet_btn_Click(object sender, EventArgs e)
        {
            diyet_ata diyet = new diyet_ata();
            diyet.Show();
            this.Hide();
        }

        private void hastalık_btn_Click(object sender, EventArgs e)
        {
            ekle_hastalık ekle = new ekle_hastalık();
            ekle.ShowDialog();
        }

        private void diyet_planı_Click(object sender, EventArgs e)
        {
            ekle_diyet ekle = new ekle_diyet();
            ekle.ShowDialog();
        }
    }
}
