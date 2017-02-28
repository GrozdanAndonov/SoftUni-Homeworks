using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {


            var num = int.Parse(Console.ReadLine());
           int spaces=num;
           int stars=num*2;

            for(int row=1;row<=num;row++)
            {
                if (row == 1)
                {
                    for (int cow = 1; cow <= stars; cow++)
                    {
                        Console.Write("*");

                    }

                    for (int cow = 1; cow <= spaces; cow++)
                    {

                        Console.Write(" ");

                    }

                    for (int cow = 1; cow <= stars; cow++)
                    {
                        Console.Write("*");

                    }
                }
                /////////////////////////PURVI RED
                if (row != 1 && row != num)
                {
                    Console.Write("*");

                    for (int cow = 1; cow <= 2 * num - 2; cow++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");

                    if (row == (num-1)/2+1)
                    {

                        for(int cow=1;cow<=spaces;cow++)
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        for (int cow = 1; cow <= spaces; cow++)
                        {
                            Console.Write(" ");
                        }
                    }


                    Console.Write("*");

                    for (int cow = 1; cow <= 2 * num - 2; cow++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");


                }
                if(row==num)
                {
                    for (int cow = 1; cow <= stars; cow++)
                    {
                        Console.Write("*");

                    }

                    for (int cow = 1; cow <= spaces; cow++)
                    {

                        Console.Write(" ");

                    }

                    for (int cow = 1; cow <= stars; cow++)
                    {
                        Console.Write("*");

                    }
                }









                Console.WriteLine();  
            }

           


        }
    }
}
