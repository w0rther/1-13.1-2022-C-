using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            List <int> szamok = new List<int>();
            using (StreamReader reader = new StreamReader("C:\\Users\\pfandler.richard\\source\\repos\\1-13.1-2022-C-\\213\\111\\Feladatok\\szamok1\\bin\\Debug\\szamok.txt")) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int szam;
                    if ( int.TryParse(line, out szam))
                    {
                        szamok.Add(szam);
                    }

                }
            }
            int max = szamok.Max();
            int index = szamok.IndexOf(max);

            Console.WriteLine(max);
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
