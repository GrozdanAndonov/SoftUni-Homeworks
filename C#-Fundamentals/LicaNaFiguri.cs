using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicaNaFiguri
{
    class Program
    {
        static void Main(string[] args)
        {
            double lice = 0;
            String name = Console.ReadLine();
            String name1="square";
            String name2="rectangle";    
            String name3="circle";
            String name4="triangle";
            if(name==name1)
            {
                
                var a = double.Parse(Console.ReadLine());
                lice =a * a;
                Console.WriteLine(lice);
            }else
            {
                if(name==name2)
                {
                    var a = double.Parse(Console.ReadLine());
                    var b = double.Parse(Console.ReadLine());
                    lice = a * b;
                    Console.WriteLine(lice);
                }else
                {
                    if(name==name3)
                    {
                        var a = double.Parse(Console.ReadLine());
                        lice = Math.PI * a * a;
                        Console.WriteLine(lice);
                    }else
                    {
                        if(name==name4)
                        {
                            var a = double.Parse(Console.ReadLine());
                            var b = double.Parse(Console.ReadLine());
                            lice = (a * b)/2;
                            Console.WriteLine(lice);
                        }

                    }
                }
            }


        }
    }
}
