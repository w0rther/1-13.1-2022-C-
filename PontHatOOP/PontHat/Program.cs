using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PontHat p = new PontHat();
            Console.WriteLine("Pontszám: ");
            int adat = int.Parse(Console.ReadLine());
            p.Szamitas(adat);
        }
    }
}
