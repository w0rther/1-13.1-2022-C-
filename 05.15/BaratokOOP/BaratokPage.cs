using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratokOOP
{
    internal class BaratokPage
    {


        #region Page

        public void Page()
        {
          
            int lapmeret = 15;
            int PageUp = 33;
            int PageDown = 34;
            int Home = 36;
            int End = 35;
            int Esc = 27;
            int p;
            int i = 0;
            bool kilepes = false;
            for (int i = 0; i < lapmeret; i++)
            {
                Console.WriteLine($"{this.list[i].Name,-20};" +
                    $"{this.list[i].szulido.ToShortDateString(),10};" +
                    $"{this.list[i].hajlam,1};" +
                    $"{this.list[i].nem,-20}");
            }
            p = Convert.ToInt32(Console.Read);
            switch (p)
            {
                case 33: // Page Up
                    if (i < lapmeret)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = i - lapmeret;
                    }
                    break;
                default:
                    break;
            }
           
        }
        #endregion Page
    }
}
