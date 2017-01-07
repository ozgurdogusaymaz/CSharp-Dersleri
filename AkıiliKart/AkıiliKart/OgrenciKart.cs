using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkıiliKart
{
    class OgrenciKart : Kart
    {
        public string okulAdi { get; set; }

        public override void Okut()
        {
            MessageBox.Show("Biniş Başarılı! KLn Bakiye:" + (bakiye - 1));
            bakiye -=1;
        }
        public override string ToString()
        {
            return KartID + "\t" + bakiye + "\t" + kartTuru + "\t" + okulAdi;
        }
    }
}
