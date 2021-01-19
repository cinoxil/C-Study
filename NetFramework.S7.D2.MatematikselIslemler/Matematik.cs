using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MatematikselIslemler
{
    class Matematik
    {
        

        public decimal toplamaIslemi(decimal a , decimal b)
        {
            decimal sonuc = a + b;
            return sonuc;
        }

        public decimal cikarmaIslemi(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal bolmeIslemi(decimal a, decimal b)
        {
            return a / b;
        }

        public decimal carpmaIslemi(decimal a, decimal b)
        {
            return a * b;
        }

        

    }
}
