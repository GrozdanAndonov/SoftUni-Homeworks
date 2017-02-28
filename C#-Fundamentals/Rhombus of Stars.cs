using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {


            var num = int.Parse(Console.ReadLine());

            int stars = 1;
            int spaces = num - 1;


            for (int row = 0; row <= num - 1; row++)
            {

                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < stars; i++)
                {
                    Console.Write("* ");

                }
                stars++;
                spaces--;
                Console.WriteLine();
            }


            spaces = 1;
            stars = num - 1;
            for (int row = 0; row <= num - 2; row++)
            {

                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < stars; i++)
                {
                    Console.Write("* ");

                }
                stars--;
                spaces++;
                Console.WriteLine();



            }
        }
    }
}
