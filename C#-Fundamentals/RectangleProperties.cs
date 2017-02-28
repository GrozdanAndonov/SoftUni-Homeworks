using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimetur = (2f * width) + (2f * height);
            Console.WriteLine(perimetur);
            double area = width * height;
            Console.WriteLine(area);

            double c=width*width+height*height;
            double diagonal = Math.Sqrt(c);
            Console.WriteLine(diagonal);

        }
    }
}
