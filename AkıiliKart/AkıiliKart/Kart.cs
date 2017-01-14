using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkıiliKart
{
    public enum YolcuTipi
    {
        Tam,
        Ögrenci,
        Öğretmen
    }
    public class Kart
    {
        public int KartID { get; set; }

        private double _bakiye;

        public double bakiye
        {
            get
            {
                return _bakiye;
            }

            set
            {
                _bakiye = value;
            }
        }
        public YolcuTipi kartTuru { get; set; }

        public virtual void Okut()
        {
            MessageBox.Show("Biniş Başarılı! KLn Bakiye:" + (bakiye - 3));
            bakiye -= 3;
        }
        public override string ToString()
        {
            return KartID + "\t" + bakiye + "\t" + kartTuru;
        }
    }
}
