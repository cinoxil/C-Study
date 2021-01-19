using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D3.SabitTanimlar
{
    class Program
    {
        static void Main(string[] args)
        {

            const int ortakBolumDeger = 2; //const yazarak int turunde ortakBolumDeger'e sabit olarak 2 degerini atadim

            int sayi1 = 1111;

            int sonuc = sayi1 / ortakBolumDeger;

            ortakBolumDeger = 5; //Bak burada hata veriyor cunku sabite sonradan deger atayamazsin


        }
    }
}
