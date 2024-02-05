using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class For : Form
    {
        public For()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sonuc = sayi1 * sayi2;
            MessageBox.Show($"karesi = {sonuc}");

        }

        private void btnSekil_Click(object sender, EventArgs e)
        {
            Sekil sekil1 = new Sekil();
            sekil1.kisakenar = Convert.ToInt32(txtSayi1.Text);
            sekil1.uzunkenar = Convert.ToInt32(txtSayi2.Text);
            sekil1.sekilCiz(btnSekil,Color.Blue);
        }

  
    }
}
