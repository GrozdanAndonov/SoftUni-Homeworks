using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i=1;
            for(int row=1;row<=num;row++)
            {
                for (int col = 1; col <= row;col++)
                {
                    if (col > 1) Console.Write(" ");
                    Console.Write(i);
                    i++;
                    if (i > num) break;
                    
                }


                    Console.WriteLine();
                if (i> num) break;
            }


        }
    }
}
