using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
         bool[] primes=new bool[num+1];

         for (int i = 0; i < primes.Length; i++)
         {
             primes[i] = true;
         }
         primes[0] = false;
         primes[1] = false;

         for (int i = 0; i < primes.Length; i++)
         {
             if(primes[i]==true)
             {
                 for (int a = 2; a < primes.Length; a++)
                 {
                     if (i * a >= primes.Length) break;
                     primes[i * a] = false;
                 }
             }
         }
         for (int i = 0; i < primes.Length; i++)
         {
             if (primes[i] == true) Console.WriteLine(i);
         }
        }
    }
}
