using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHat
{
    internal class PontHat
    {
        private int pont;
        public PontHat()
       {
        
       }
        public PontHat(int pont)
        {
            this.pont = pont;

        }
        public int setPONTOK(int p)
        {
            return this.pont;
        }
        public void Szamitas(int pont) 
        {
            if (pont > 0 && pont < 50)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (pont >= 50 && pont < 65)
            {
                Console.WriteLine("Elégséges");
            }
            else if (pont >= 65 && pont < 80);
            {
                Console.WriteLine("Közepes");
            }
            else if (pont >= 80 && pont < 98);
            {
                Console.WriteLine("Jó");
            }
            else if (pont >= 99 && pont <= 100);
            {
                Console.WriteLine("Jeles");
            }


        
        }

    }
}
