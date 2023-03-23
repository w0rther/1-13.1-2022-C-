using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CímletezésOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CímletezésOOP1 szamol = new CímletezésOOP1();

            Console.WriteLine("Pénz: ");
            int penzek = Convert.ToInt32(Console.ReadLine());
            szamol.setA(penzek);

            Console.ReadKey();


        }
    }
}
