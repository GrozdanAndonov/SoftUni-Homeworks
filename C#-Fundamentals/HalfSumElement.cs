using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = max;
            for(int i=0;i<=num-2;i++)
            {

                var num1 = int.Parse(Console.ReadLine());
                
                if(num1>max)
                {
                    max = num1;
                }
                sum += num1;
            }

            sum -= max;
            if(sum==max)
            {
                Console.WriteLine("Yes, sum {0}", sum);
            }
            else
            {
                Console.WriteLine("no, diff {0}", Math.Abs(sum - max));
            }


        }
    }
}
