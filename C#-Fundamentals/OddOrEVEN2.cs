using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEVEN2
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            double oddSum=0;
            double oddMax = -1000000000.0;
            double oddMin = 1000000000.0;
            double evenSum = 0;
            double evenMax = -1000000000.0;
            double evenMin = 1000000000.0;



            for(int i=1;i<=num;i++)
            {

                var num1 = double.Parse(Console.ReadLine());

                if(i % 2 != 0)
                {
                    oddSum += num1;
                    if(num1>oddMax)
                    {
                        oddMax = num1;
                    }
                    if(num1<oddMin)
                    {
                        oddMin = num1;
                    }
                }
                if(i % 2 == 0)
                {
                    evenSum += num1;
                    if (num1 > evenMax)
                    {
                        evenMax = num1;
                    }
                    if (num1 < evenMin)
                    {
                        evenMin = num1;
                    }

                }

            }

            Console.WriteLine("OddSum={0},", oddSum);

            if (oddMin == 1000000000.0 && oddMax == -1000000000.0)
            {

                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");



            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
            }

            Console.WriteLine("EvenSum={0},", evenSum);

            if (evenMin == 1000000000.0 && evenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }





           







        }
    }
}
