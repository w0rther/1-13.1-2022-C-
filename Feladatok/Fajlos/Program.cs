using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace Fajlos
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            StreamWriter sw = new StreamWriter("adat.txt");
            Random r = new Random();
            for (int i = 0; i < 12500; i++) 
            {
                sw.WriteLine(r.Next(1,12500));
            }
            sw.Close();

            string[] t = File.ReadAllLines("adat.txt");
            for (int i = 0;i < t.Length;i++) 
            {
                Console.WriteLine(t[i]);
                
            }

 




            Console.ReadKey();
        }
    }
}
