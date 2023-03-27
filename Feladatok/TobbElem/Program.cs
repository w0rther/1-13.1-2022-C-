using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ossz = 0;
            int paros = 0;
            int paratlan = 0;

            do
            {
                int szam = 0;
                Console.WriteLine("Adj meg egy egész számot");
                szam = Convert.ToInt32(Console.ReadLine());
                ossz = ossz + szam;

                if (szam % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }
            }
            while (ossz < 100);
            Console.WriteLine("Páros számok: {0}", paros);
            Console.WriteLine("Páratlan számok: {0}", paratlan);
            Console.ReadLine();
        }
    }
}
