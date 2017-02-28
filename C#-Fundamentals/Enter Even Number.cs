using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            int i;
            do
            {
                try
                {
                    Console.Write("Enter even number:");
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
                i = a % 2;
                if(i!=0)
                {
                    Console.WriteLine("Invalid number");
                }

            } while (i != 0);
            Console.WriteLine("Even number entered: {0}", a);

        }
    }
}
