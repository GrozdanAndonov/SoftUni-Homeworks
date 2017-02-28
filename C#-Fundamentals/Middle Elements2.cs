using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Elements2
{
    class Program
    {
        static void Main(string[] args)
        {

            var mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            foreach(int n in MidELement(mas)) Console.WriteLine(n);


        }

        static int[] MidELement(int[] mas)
        {
            if (mas.Length == 1)
                Console.WriteLine(mas[0]);

            if (mas.Length % 2 == 0)
            {
                int n = mas.Length / 2;
                Console.WriteLine("{0} {1}", mas[n - 1], mas[n]);
            }
            if (mas.Length > 1 && mas.Length % 2 != 0)
            {
                int n = mas.Length / 2;
                Console.WriteLine("{0} {1} {2}", mas[n - 1], mas[n], mas[n + 1]);
            }

            int[] mas2 = {5, 5, 5, 5};


            return mas2;
        }

    }
}
