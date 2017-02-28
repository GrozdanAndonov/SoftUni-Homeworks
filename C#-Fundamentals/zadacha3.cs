using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int n = 0;
            //int n = num / 2;
            //Console.WriteLine(n);
            for (int row = 0; row < num/2; row++)
            {

                Console.Write(new string('-', n));
                Console.Write("\\");
                Console.Write(new string('-', num-n));
                Console.Write("|");
                Console.Write(new string('-', num-n));
                Console.Write("/");
                Console.Write(new string('-', n));               
                n += 2;
                Console.WriteLine();
            }

            Console.Write(new string('-', num));
            Console.Write("#.#");
            Console.Write(new string('-', num));
            Console.WriteLine();
            //////////////////////////////////////////////////

              n=2;
          int b = 0;
          int c=5;
            for (int i = 0; i < num/2; i++)
            {
                
                 Console.Write(new string('-', num-n));
                 Console.Write("#");
                 Console.Write(new string('.', c+b));
                 Console.Write("#");
                 Console.Write(new string('-', num - n));
                 n += 2;
                 b += 4;
                 Console.WriteLine();

            }

            Console.Write("#");
            Console.Write(new string('.', num*2 + 1));
            Console.Write("#");
            Console.WriteLine();
            ///////////////////////////////////////////////

            int num2=1;
            int num3=1;
            for (int i = 0; i < num-1; i++)
            {

               Console.Write(new string('-',num2));
                Console.Write("#");
                Console.Write(new string('.',num*2-num3));
                Console.Write("#");
                Console.Write(new string('-', num2));
                num3 += 2;
                num2++;
                Console.WriteLine();
            }

            Console.Write(new string('-', num));
            Console.Write("#.#");
            Console.Write(new string('-', num));

        }
    }
}
