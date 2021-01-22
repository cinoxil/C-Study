using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    public class Ogrenci
    {

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne ornegi alindiktan sonra calisir");
            Test2();
            //static olmayan bir method static bir ,ethodu cagirabilir
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne ornegi ALINMADAN kullanilabilir");
            //test1();
            //static bir method static olmayan birseyi cagiramaz
        }

    }
}
