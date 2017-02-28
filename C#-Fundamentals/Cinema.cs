using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            String type = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if(type=="premiere")
            {
                Console.WriteLine("{0:f2} leva",r * c * 12);

            }
            else
            {
                if(type=="normal")
                {
                    Console.WriteLine("{0:f2} leva",r * c * 7.5);
                }
                else
                {
                    if(type=="discount")
                    {
                        Console.WriteLine("{0:f2} leva",r * c * 5);
                    }
                }
            }


        }
    }
}
