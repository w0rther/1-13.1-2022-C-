using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CímletezésOOP
{
    
    internal class CímletezésOOP
    {
        private int a;
        private int[] b = { 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 };
        public void SetA(int a) {
            Console.WriteLine("Pénz");
            this.a = Convert.ToInt32(
                Console.ReadLine()
                );
            if (this.a < 5)
            {
                Console.WriteLine("Hibás adat!");

            }
            else if (this.a > 5) {
                for (int i = 0; i  < b[i].Length ; i++) { }
                {

                }
            }
        }
        public int GetA () { return this.a; }
    }
}
