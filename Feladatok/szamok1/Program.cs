using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;

            Console.WriteLine("Adja meg hány számot szeretne legenerálni?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérjük adja meg a fájl nevét:");
            string fileName = Console.ReadLine();

            Random random = new Random();
            using (StreamWriter writer = new StreamWriter(fileName + ".txt"))
            {

                for (int i = 0; i < n; i++)
                {
                    randomNumber = random.Next(1, 1000);
                    writer.WriteLine(randomNumber);
                }
            }
            Console.ReadLine();
        }
    }
}
