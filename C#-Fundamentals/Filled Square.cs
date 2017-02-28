using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            printHeader(i);
            printMid(i);
            printHeader(i);
        }


        static void printHeader(int i)
        {
            Console.WriteLine(new string('-', i*2));
        }

        static void printMid(int i)
        {
            for(int n=0;n<i-2;n++)
            {
                Console.Write("-");
                for(int num=1;num<i;num++)
                {
                    Console.Write(@"\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }

        }

    }
}
