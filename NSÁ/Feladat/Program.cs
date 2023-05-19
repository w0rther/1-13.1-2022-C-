using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy nevet!");
            Console.ReadLine();
            Console.WriteLine("Adj meg egy kort!");


            string file = Console.ReadLine();
            using (StreamWriter fajl = new StreamWriter(file + ".txt"))
            Console.ReadKey();
        }
    }
}