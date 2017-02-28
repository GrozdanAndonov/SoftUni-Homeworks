using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 2) { Console.WriteLine("1"); return; }
            int f0 = 1;
            int f1 = 1;        
            for (int i = 1; i < num; i++)
            {

              var n = f0 + f1;
              f0 = f1;
              f1 = n;
             // Console.WriteLine(f1);
            }
            Console.WriteLine(f1);
        }
    }
}
