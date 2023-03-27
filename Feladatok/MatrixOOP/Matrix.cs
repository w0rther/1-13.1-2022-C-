using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOOP
{
    internal class Matrix
    {
        private int[,] matrix;
        Random r = new Random();
        private int  also=1, felso=100;
        //Konstruktorok

        public Matrix(int meret) { matrix = new int[meret, meret];}

        public void setMatrix()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    this.matrix[i, j] = r.Next(also, felso);
                }
            }


        }
        public int[,] getMatrix() { return  this.matrix; }
    }
}
