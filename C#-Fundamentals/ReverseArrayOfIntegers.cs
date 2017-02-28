using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            int[] mas = new int[times];

            for (int i = 0; i < times; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());

            }
            mas.Reverse();
            for (int i = times-1; i >=0; i--)
            {
                Console.Write("{0} ", mas[i]);

            }


        }
    }
}
