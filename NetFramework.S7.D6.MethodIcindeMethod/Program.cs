using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D8.MethodIcindeMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            LocalFunctionKullanimi(5, 4);
            Console.ReadLine();

        }

        static void LocalFunctionKullanimi(int sayi1,int sayi2)
        {

            int topla(int gelenSayi1,int gelenSayi2)
            {
                return gelenSayi1 + gelenSayi2;
            }

            int toplamDeger = topla(sayi1, sayi2);
            Console.WriteLine(toplamDeger);
        }
    }
}
