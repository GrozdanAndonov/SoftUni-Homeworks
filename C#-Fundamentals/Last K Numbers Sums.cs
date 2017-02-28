using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var mas = new BigInteger[n];
            mas[0] = 1;
           for(int i=1;i<n;i++)
            {
                long sum = 0;
                for(int b=i-k ;b<=i-1;b++)
                {
                    if (b >= 0)
                    {
                        sum += mas[b];
                    }
                                       
                }
                mas[i] = sum;
            }
            for (int b = 0; b < mas.Length; b++)
                Console.WriteLine(mas[b]);




        }
    }
}
