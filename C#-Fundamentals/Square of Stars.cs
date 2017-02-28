using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for(int a=0;a<num;a++)
            {
                Console.Write("*");
                for(int b=0;b<num-1;b++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
