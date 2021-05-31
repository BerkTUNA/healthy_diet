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
    public partial class diyetisyenler : Form
    {
        public diyetisyenler()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            admin_paneli admin_ana = new admin_paneli();
            admin_ana.Show();
            this.Hide();
        }

       

        private void ekle_diyetis_Click(object sender, EventArgs e)
        {
            ekle_diyetisyen ekle = new ekle_diyetisyen();
            ekle.Show();
            this.Hide();
        }
    }
}
