using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D4.ForeachGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Isimler = new[] { "Cengiz Atilla", "Mustafa Gokmen", "Mustafa Sel", "Ugur Celik" };

            foreach (string a in Isimler)//a yerine istedimizi yazariz Isimler dizisinin icindeki degeri a'ya esitliyor
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();

        }
    }
}
