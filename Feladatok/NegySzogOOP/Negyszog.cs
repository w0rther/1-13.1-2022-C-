﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NegyszogOOP
{
    internal class Negyszog
    {
        public int i = 0, x = 0, y = 0;
        Random rnd = new Random(); 
        public int ran; 
        public Negyszog() { }
        public Negyszog(int i, int x, int y, int ran)
        {
            this.i = i;
            this.x = x;
            this.y = y;
            this.ran = ran;
        }
        public void kiiratas()
        {
            while (x < 79)
            {
                i = 0;
                ran = rnd.Next(2, 10);
                while (i < ran && x < 79)
                {
                    i++; x++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                }
                i = 0;
                while (i < 8 && x < 79)
                {
                    i++; y--;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                }
                ran = rnd.Next(2, 10);
                i = 0;
                while (i < ran && x < 79)
                {
                    i++; x++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                }
                i = 0;
                while (i < 8 && x < 79)
                {
                    i++; y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                }
            }
        }

    }
}