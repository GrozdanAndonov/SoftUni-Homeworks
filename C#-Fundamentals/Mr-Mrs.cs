using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr_Mrs
{
    class Program
    {
        static void Main(string[] args)
        {

            var age = double.Parse(Console.ReadLine());
            String sex = Console.ReadLine();
            String woman = "f";
            String men = "m";

            if (sex == woman)
            {
                if (age < 16) Console.WriteLine("Miss");
                if (age >= 16) Console.WriteLine("Ms.");
            }
            if (sex == men)
            {
                if (age < 16) Console.WriteLine("Master");
                if (age >= 16) Console.WriteLine("Mr.");
            }
            

        }
    }
}
