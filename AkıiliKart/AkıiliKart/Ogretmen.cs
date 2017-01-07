using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkıiliKart
{
    class Ogretmen : Kart
    {
        public override void Okut()

        {
            MessageBox.Show("Biniş Başarılı! KLn Bakiye:" + (bakiye - 2));
            bakiye -= 2;
        }
    }
}
