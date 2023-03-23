using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CímletezésOOP
{
    internal class CímletezésOOP1
    {
        private int a;
        private int[] b = { 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 };

        public CímletezésOOP1() { }

        public CímletezésOOP1(int a)
        {
            this.a = a;
        }
        public int getA() { return this.a; }
        public void setA(int a)
        {
            int mar = 0;
            this.a = a;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                while (a >= b[i])
                {
                    a -= b[i];
                    mar++;
                }
            }
            Console.WriteLine(mar);
        }




    }

}
