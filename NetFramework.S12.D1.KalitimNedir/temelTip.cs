using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class temelTip
    {
        public int Id { get; set; }
        public string ReferansKod { get; set; }
        public string TcKimlikNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Cinsiyet { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int KayitKullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int GuncellemeKullanici { get; set; }
        public bool Silindi { get; set; }

    }
}
