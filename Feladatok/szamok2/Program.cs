using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;



namespace Szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Mennyit számok generáljak: ");
            int mennyiseg = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < mennyiseg; i++)
            {
                int szamok = rnd.Next(1, 1000);
                Console.WriteLine(szamok);
            }
            Console.WriteLine("Mi legyen a file-nak a neve?");
            string file = Console.ReadLine();
            using (StreamWriter fajl = new StreamWriter(file + ".txt"))
            {
                Console.WriteLine("Írja a fájlt");
            }
            Console.ReadKey();
        }
    }
}

    
