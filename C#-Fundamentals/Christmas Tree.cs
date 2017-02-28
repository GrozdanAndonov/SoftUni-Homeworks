using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            int spaces = num + 1;
            int stars = 0;
            int stable=num+1;


           for(int row=1;row<=num+1;row++)
           {

               for (int cow = 1; cow <= spaces-1; cow++)
               {
                   Console.Write(" ");
                   
               }
                   
                   spaces--;

                   for (int cow = 1; cow <= stars;cow++)
                   {

                       Console.Write("*");
                   }
                   Console.Write(" ");
                   Console.Write("|");
                   Console.Write(" ");
                   stars++;

                   for (int cow = 1; cow <= stars-1; cow++)
                   {

                       Console.Write("*");
                   }                  
                       Console.WriteLine();
           }
        }
    }
}
