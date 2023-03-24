using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (n % 3 == 0) Console.WriteLine("A szám osztható 3-mal");
            else Console.WriteLine("A szám nem osztható 3-mal");
            if (n % 4 == 0) Console.WriteLine("A szám osztható 4-gyal");
            else Console.WriteLine("A szám nem osztható 4-gyal");
            if (n % 9 == 0) Console.WriteLine("A szám osztható 9-cel");
            else Console.WriteLine("A szám nem osztható 9-cel");

            Console.ReadLine();
        }
    }
}
