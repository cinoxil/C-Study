using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class Egitmen:temelTip
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzinGunSayisi { get; set; }
    }
}
