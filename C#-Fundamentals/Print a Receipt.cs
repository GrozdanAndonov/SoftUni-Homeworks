using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine(@"/----------------------\");
            foreach(var num in str)
            {
                Console.WriteLine("|{0,21:f2} |", num);

            }
            Console.WriteLine(@"|----------------------|");
            Console.WriteLine(@"| Total: {0,13:f2} |",str.Sum());
            Console.WriteLine(@"\----------------------/");
            //double sum = 0;
            //for(int i=0;i<str.Length;i++)
            //{
            //    sum += str[i];
            //}
            //Console.WriteLine(sum);

        }
    }
}
