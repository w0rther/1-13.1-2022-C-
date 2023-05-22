using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Dolgozat
{

    class Program
    {
        static void Main(string[] args)
        {


            List<int> allatkert = new List<int>();



            try
            {
                //beolvasás
                FileStream fs = new FileStream("allatkert.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string sor = "";
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    allatkert.Add(Convert.ToInt32(sor));
                }

                sr.Close();
                fs.Close();
                Console.WriteLine("A beolvasás sikeres!");
            }
            catch (Exception hiba)
            {
                Console.WriteLine("Hiba a beolvasáskor: " + hiba);
            }
           
            Console.WriteLine("Nyomd le az ENTERT a folytatáshoz!");
            Console.ReadLine();

            Console.WriteLine("A lista elemei:");
            for (int i = 0; i < allatkert.Count; i++)
            {
                Console.Write(allatkert[i] + " ");
            }
        Console.WriteLine("");
            Console.WriteLine("Összesen a héten ennyien látogatták meg az állatkertet: " + allatkert.Sum());

            //200-nál több ember
            int db200 = 0;
            foreach (int szam in allatkert)
            {
                if (szam > 200)
                {
                    db200++;
                }
            }

   
            Console.WriteLine("Ennyiszer voltak 200-nál többen: " + db200);
            
            Console.WriteLine("A legtöbb látogató egy napon: " + allatkert.Max());
            for (int i = 0; i < allatkert.Count; i++)
       
            {
                if (allatkert[i] == allatkert.Max())
                {
                    Console.WriteLine((i + 1) + ". napon");
                }
            }

            Console.ReadKey();
        }
    }
}