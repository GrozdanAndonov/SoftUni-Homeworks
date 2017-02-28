using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            int factoriel = 1;

            do
            {
                factoriel = factoriel * num;
                num--;

            } while (num > 1);

            Console.WriteLine(factoriel);
        }
    }
}
