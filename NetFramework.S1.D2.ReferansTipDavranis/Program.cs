using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D2.ReferansTipDavranis
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba arabaTanimi1 = new Araba();

            arabaTanimi1.marka = "Opel";
            arabaTanimi1.model = "Corsa";
            arabaTanimi1.renk = "Siyah";

            Console.Write("Marka : ");
            Console.WriteLine(arabaTanimi1.marka);
            Console.Write("Model : ");
            Console.WriteLine(arabaTanimi1.model);
            Console.Write("Renk : ");
            Console.WriteLine(arabaTanimi1.renk);

            Console.ReadKey();

            Araba arabaTanimi2 = arabaTanimi1; // Burada arabaTanimi1'i arabaTanimi 2'ye esitliyoruz yani bir nevi arabaTanimi2 arabaTanimi1'i point ediyor

            arabaTanimi2.renk = "Gri";
            arabaTanimi2.model = "Zafira";

            Console.Write("Marka : ");
            Console.WriteLine(arabaTanimi1.marka);
            Console.Write("Model : ");
            Console.WriteLine(arabaTanimi1.model);
            Console.Write("Renk : ");
            Console.WriteLine(arabaTanimi1.renk);

            Console.ReadKey();


        }

        class Araba
        {
            public string marka;
            public string model;
            public string renk;
        }

    }
}
