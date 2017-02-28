using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var mas1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var mas2 = new int[mas1.Length];

            for(int i=0;i<mas1.Length;i++)
            {

                 mas2[(mas2.Length-1) - i] = mas1[i];

            }

            for (int i = 0; i < mas2.Length; i++) Console.Write("{0} ", mas2[i]);



        }
    }
}
