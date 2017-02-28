using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1=0;
            int lastSum = 0;
            int maxSum = -1000000000;
            int minSum =  1000000000;
            int maxDiff = 0;
            int maxdiff2=0;
            var times = int.Parse(Console.ReadLine());

            for(int a=0;a<times;a++)
            {

                for(int b=0;b<2;b++)
                {
                    var num = int.Parse(Console.ReadLine());

                     sum1+=num;
                }

                if (sum1 > maxSum) maxSum = sum1;
                if (sum1 < minSum) minSum = sum1;

                 maxDiff = maxSum - minSum;

               

               
                

                sum1 = 0;

            }

            if(maxDiff==0)
            {
                Console.WriteLine("Yes, value= {0}",maxSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }

        }
    }
}
