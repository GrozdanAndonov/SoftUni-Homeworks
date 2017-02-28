using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {

            int stars = 1;

            var n = int.Parse(Console.ReadLine());
            //pokriv

            if (n % 2 == 0)
            {
                stars = 2;
            }
                    

            for(int row=1;row<=(n + 1) / 2 ;row++)
            {


                var hyphens = (n - stars) / 2;
                Console.Write(new string('-', hyphens));
                    
                    
                        Console.Write(new string ('*',stars));
                        Console.Write(new string('-', hyphens));
                        stars += 2;
                Console.WriteLine();

            }

            for(int row=1;row<=n-((n + 1) / 2);row++)
            {
                Console.Write("|");

                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");

            }





        }
    }
}
