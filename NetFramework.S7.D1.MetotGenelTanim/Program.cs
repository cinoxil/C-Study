using System;
using System.Collections.Generic; //bu using kullanilanlar kutuphaneler ornegin console.writeline komuyu system kutuphanesinden cekilir
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.MetotGenelTanim //projemizin namespace'ide ayni zamanda bir kutuphanedir 
{
    class Program
    {
        static void Main(string[] args)
        {

            //ornek console.writeline uzun yazimi
            //System.Console.WriteLine("Merhaba");

            //kisa yazimi ise
            //Console.WriteLine("Merhaba");

            Ogrenci O1 = new Ogrenci();

            Selamla();
            O1.selamlaOgrenci();

            Console.ReadLine();

        }

        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
