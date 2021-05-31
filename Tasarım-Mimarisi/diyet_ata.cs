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
    public partial class diyet_ata : Form
    {
        public diyet_ata()
        {
            InitializeComponent();
        }

        private void diyet_ata_Load(object sender, EventArgs e)
        {

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.Show();
            this.Hide();
        }
    }
}
