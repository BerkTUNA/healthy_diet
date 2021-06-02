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
    public partial class ekle_diyetisyen : Form
    {
        public ekle_diyetisyen()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            diyetisyenler diyetis_lis = new diyetisyenler();
            diyetis_lis.Show();
            this.Hide();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
