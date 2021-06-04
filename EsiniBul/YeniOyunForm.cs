using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class YeniOyunForm : Form
    {
        public YeniOyunForm()
        {
            InitializeComponent();
        }

        private void btnOyunuBaşlat_Click(object sender, EventArgs e)
        {
            ZorlukSeviye zs = rbKolay.Checked ? ZorlukSeviye.Kolay : (rbOrta.Checked ? ZorlukSeviye.Orta : ZorlukSeviye.Zor);

            Form1 frmOyun = new Form1(zs);
            frmOyun.Show(this);
            Hide();

            //bu formu frmoyun formunun owner ı yap.
            //new Form1().Show(this);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
