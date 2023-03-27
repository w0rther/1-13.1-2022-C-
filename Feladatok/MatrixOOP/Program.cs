using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a mátrix méretét: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Matrix m1 = new Matrix(m);
            m1.setMatrix();
            for (int i = 0; i < m1.getMatrix().GetLength(0); i++)
            {
                for (int j = 0; j < m1.getMatrix().GetLength(1); j++)
                {
                    Console.Write(m1.getMatrix()[i, j]+", ");
                    
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
