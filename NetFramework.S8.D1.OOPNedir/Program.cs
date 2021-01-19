using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri M1 = new Musteri("365810024852", "Sait", "Ongun");

            M1.TcKimlikNo = "36581078856";
            M1.ad = "Ugur";
            M1.soyad = "Ongun";
            M1.cinsiyet = 717770001;
            M1.durum = M1.MusteriKontrol();

            Musteri M2 = M1;

            M2.ad = "cuneyt";
            M1.TcKimlikNo = "36471078236";

            Console.ReadLine();

            //M1 = null;
            //M2 = null;

            //yukarida su oldu m1 ve m2yi pointer gibi dusunebiliriz. Yani musteri classini point ediyorlar. Yukarida ikisinide nukk yaptik yani musteri classini point eden birsey kalmadi
            //bu nedenle musteri classinin ici ram'den duser ve garbage collector tarafindan silinir cunku nesneler referans tiplidir

        }
    }
}
