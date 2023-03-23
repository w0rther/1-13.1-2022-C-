using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Melyik akar váltani? Celsius vagy fahrenheit?");
            string c = Console.ReadKey().ToString();
            Console.WriteLine("\nAdja meg a hőfokot: ");
            int h = Convert.ToInt32(Console.ReadLine());
            if (c == "c" || c == "C")
            {
                Console.WriteLine("{0} Fahrenheit fok= {1} Celsius", h, (h - 32) / 1.8);

            }
            else { Console.WriteLine("{0} Fahrenheit fok= {1} Celsius", h, (h * 1.8) + 32); }

            Console.ReadKey();
        }
    }
}
