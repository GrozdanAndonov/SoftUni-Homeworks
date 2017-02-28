using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            int flag=0;
            int counter = 0;


                  Console.Write('+');
                    for (int num = 1; num <= n - 2; num++)
                        Console.Write(" -");
                    Console.WriteLine(" +");


            for(int row=1;row<=n-2;row++)
            {
                
                   
                        Console.Write("|");
                        for (int num = 1; num <= n - 2; num++)
                            Console.Write(" -");
                        Console.Write(" |");
                 
                Console.WriteLine();
                
            }
            Console.Write('+');
                    for (int num = 1; num <= n - 2; num++)
                        Console.Write(" -");
                    Console.WriteLine(" +");




        }
    }
}
