using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İzsu
{
    class Abone
    {
        public string aboneNo;
        public string adi;
        public string evKurum;
        public string oncekiSayac;
        public string sonSayac;

        public override string ToString()
        {
            return this.adi + "\t" + this.evKurum + "\t" + this.oncekiSayac + "\t" + this.sonSayac;
        }

    }
}
