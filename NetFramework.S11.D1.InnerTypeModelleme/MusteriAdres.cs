using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class MusteriAdres
    {
        public string adresTip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }

        public MusteriAdres()
        {
            
        }

        public void ekranaYaz()
        {
            Console.WriteLine("Merahaba kardes");
        }

    }
}
