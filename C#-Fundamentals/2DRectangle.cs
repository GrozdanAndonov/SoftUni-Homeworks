using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x2 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x1 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            
            var a = x2 - x1;
            var b = y2 - y1;

             a = Math.Max(x1, x2) - Math.Min(x1, x2);
             b = Math.Max(y1, y2) - Math.Min(y1, y2);
             Console.WriteLine(a * b);
             Console.WriteLine(2 * (a + b));
            

        }
    }
}
