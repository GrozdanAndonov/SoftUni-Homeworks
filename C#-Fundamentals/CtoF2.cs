using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoF2
{
    class Program
    {
        static void Main(string[] args)
        {
            var us = double.Parse(Console.ReadLine());
            var bg = us * 1.79549;
            Console.WriteLine(Math.Round(bg,2));
        }
    }
}
