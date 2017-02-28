using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validNum
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = double.Parse(Console.ReadLine());

            if (num >= 100 && num <= 200 || num==0) Console.WriteLine("");
            else Console.WriteLine("invalid");
        }
    }
}
