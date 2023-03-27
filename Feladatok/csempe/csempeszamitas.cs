using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempe
{
    internal class csempeszamitas
    {
        public double a, b, cs, T, TT;
        public csempeszamitas() { }
        public csempeszamitas(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void setA(double a)
        { this.a = a; }
        public void setB(double b)
        { this.b = b; }
        public void setT()
        { this.T = this.a * this.b; }
        public void setCS()
        { 
            this.cs = this.T / (0.2 * 0.2); 
        }
        public void setTT()
        {
            this.TT = Math.Round(this.cs * 1.1);
        }
        public double getA() { return this.a; }
        public double getB() { return this.b; }
        public double getCS() { return this.cs; }
        public double getT() { return this.T; }
        public double getTT() { return this.TT; }

    }
}
