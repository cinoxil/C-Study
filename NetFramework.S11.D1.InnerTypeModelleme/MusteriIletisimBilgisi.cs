using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class MusteriIletisimBilgisi
    {
        public int iletisimTip { get; set; } // 717770001 : Mobil - 7177770002 : Sabit Hat
        public string alanKodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }
    }
}
