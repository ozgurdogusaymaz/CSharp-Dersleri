using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkıiliKart
{
    public partial class Yukleme : Form
    {
        Kart gelenYolcu = new Kart();

        public Yukleme(Kart yolcu)
        {
            InitializeComponent();
            gelenYolcu = yolcu;
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            gelenYolcu.bakiye += Convert.ToDouble(txtYuklemeMiktari.Text);

            Form1 frm = new Form1(gelenYolcu);
            frm.Show();
            this.Hide();

        }
    }
}
