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
    public partial class ekle_hastalık : Form
    {
        public ekle_hastalık()
        {
            InitializeComponent();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastalık Eklendi", "Tamam");
            this.Hide();
        }
    }
}
