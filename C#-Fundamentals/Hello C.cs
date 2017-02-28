using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
          
            
                Console.WriteLine(new string('*', a));
                for (int row = 2; row <= a - 1;row++ )
                {
                    Console.Write("*");
                    for (int i = 1; i <= a - 2;i++ )
                        Console.Write(" ");
                    Console.Write("*");
                    Console.WriteLine();
                    
                }

                    Console.WriteLine(new string('*', a));

        }

    }
}
