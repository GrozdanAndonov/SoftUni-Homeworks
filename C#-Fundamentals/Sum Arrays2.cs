using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {

            var mas1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var mas2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = Math.Max(mas1.Length, mas2.Length);
            var sumMas = new int[n];
            for(int i=0;i<sumMas.Length;i++)
            {
                sumMas[i] = mas1[i % mas1.Length] + mas2[i % mas2.Length];
            }
            Console.WriteLine(string.Join(" ", sumMas));


        }
    }
}
