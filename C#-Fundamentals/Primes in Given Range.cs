using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for ( int i=num1 ; i <= num2; i++)
            {

                int maxDiv = (int)Math.Sqrt(i);
                for (long a = 2; a <= maxDiv; a++)
                {

                    if (i % a != 0)
                    {
                        Console.Write("{0} ", i); 
                    }
                }
                
            }


            //if (num <= 1) return false;
            //int maxDiv = (int)Math.Sqrt(num);
            //for (long i = 2; i <= maxDiv; i++)
            //{

            //    if (num % i == 0)
            //    {
            //        return false;
            //    }
            //}
            //return true;


        }
    }
}
