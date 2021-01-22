using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class MusteriSiparisBilgisi
    {
        public string siparisNumarasi { get; set; }

        public Urun[] urunBilgileri;
        public MusteriSiparisBilgisi()
        {
            urunBilgileri = new Urun[10];
        }
        
    }
}
