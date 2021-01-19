using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D3.IfElseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            int sinav1, sinav2, sinav3;
            double ortalama;

            Console.Write("Lutfen 1.sinav notunu giriniz : ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen 2.sinav notunu giriniz : ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen 3.sinav notunu giriniz : ");
            sinav3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1 + sinav2 + sinav3) / 3;

            if(ortalama>= 50)
            {
                Console.WriteLine("Tebrikler ortalamaniz {0}. Dersten gectiniz", ortalama);
            }
            else
            {
                Console.WriteLine("Uzgunum ortalamaniz {0}. Dersten kaldiniz", ortalama);
            }

            Console.ReadLine();





        }
    }
}
