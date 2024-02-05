using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Sekil
    {
        public int uzunkenar { get; set; }
        public int kisakenar { get; set; }



        public void kareyaz()
        {
            int sonuc = this.uzunkenar*this.kisakenar;
            MessageBox.Show($"Şeklin Karesi:{sonuc}");

        }
        public void sekilCiz(Button btn,Color  renk)
        {
            btn.Width = this.uzunkenar;
            btn.Height = this.kisakenar;
            btn.BackColor = renk;
        }
    }
}
