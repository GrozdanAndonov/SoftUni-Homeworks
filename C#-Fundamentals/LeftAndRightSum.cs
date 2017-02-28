using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            for(int i=1;i<=num;i++)
            {
                var n = int.Parse(Console.ReadLine());

                sum1 += n;

            }
            for (int i = 1; i <= num; i++)
            {
                var n = int.Parse(Console.ReadLine());

                sum2 += n;
            }
            if(sum1==sum2)
            {
                Console.WriteLine("Yes, sum = "+sum1);
            }
            else
            {
                Console.WriteLine("No, diff = "+ Math.Abs(sum1-sum2));
            }


        }
    }
}
