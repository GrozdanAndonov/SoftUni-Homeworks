using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolnoZadacha1
{
    class Program
    {
        static void Main(string[] args)
        {

            var a1=double.Parse(Console.ReadLine());
            var b1 = double.Parse(Console.ReadLine());
//////////////////////////////////////////////////////////////////////
            if(3<=b1 && b1<=a1 && a1<=100)
            {
                a1 = a1 * 100;
                int a = Convert.ToInt32(a1);
                b1 = b1 * 100;
                int b = Convert.ToInt32(b1);
//////////////////////////////////////////////////////////////////////
                b = b - 100;//mahame koridora
                double deskRed = b / 70;//bura na red
                int red;
                red = Convert.ToInt32(deskRed);
                
//////////////////////////////////////////////////////////////////////
                double deskCol = a / 120;
                int col;
                col=Convert.ToInt32(deskCol);
//////////////////////////////////////////////////////////////////////
                int numMesta = col * red - 3;
                Console.WriteLine(numMesta);

           }




        }
    }
}
