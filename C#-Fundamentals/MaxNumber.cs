using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var count = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count - 1; i++)
            {

                var num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }

            }

            Console.WriteLine(min);

        }
    }
}
