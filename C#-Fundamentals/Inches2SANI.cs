using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches2Santimeters
{
    class Inches2SANI
    {
        static void Main(string[] args)
        {
           
                Console.Write("Inches=");
                var a = double.Parse(Console.ReadLine());
                var b = a * 2.54;
                Console.WriteLine("Santimeters={0}", b);
            
        }
    }
}
