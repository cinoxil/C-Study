using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D1.DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            string isim;
            isim = "Cüneyt";

            Console.Write("Kullanıcı Adı : ");
            Console.WriteLine(isim);
            Console.ReadKey();

            int i = 4;
            int y = i;

            Console.Write("i'nin değeri : ");
            Console.WriteLine(i);
            Console.Write("y'nin değeri : ");
            Console.WriteLine(y);
            
            Console.ReadKey();
            
           
            y = 10;

            Console.Write("i'nin değeri : ");
            Console.WriteLine(i);
            Console.Write("y'nin değeri : ");
            Console.WriteLine(y);

            Console.ReadKey();

            int sayi1, sayi2;

            sayi1 = int.MinValue;
            sayi2 = int.MaxValue;

            Console.Write("En küçük int : ");
            Console.WriteLine(sayi1);
            Console.Write("En büyük int : ");
            Console.WriteLine(sayi2);

            Console.ReadKey();
            


        }
    }
}
