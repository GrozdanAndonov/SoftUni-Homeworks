using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOReven
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for(int i=1;i<=num;i++)
            {
                var num1 = int.Parse(Console.ReadLine());

                if(i%2==0)
                {
                    sum1 += num1;
                }
                else
                {
                    sum2 += num1;
                }


            }
            if(sum1==sum2)
            {
                Console.WriteLine("Yes, sum {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff {0} ",  Math.Abs(sum1 - sum2));
            }

        }
    }
}
