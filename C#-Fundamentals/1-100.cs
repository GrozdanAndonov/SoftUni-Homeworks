using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var i=int.Parse(Console.ReadLine());
            double sum;

            for ( int num=0 ; num <i ; num++)
            {

                var b = double.Parse(Console.ReadLine());
                
                sum = sum + b;
            }

        }
    }
}
