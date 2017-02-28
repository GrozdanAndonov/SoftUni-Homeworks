using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            String type = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            int b;
            if(type=="leap")
            {
                 b = 48 - h;
              var  tp = b * 3.0 / 4;
              var c = p * 2.0 / 3;
             var g= tp + h + c;
            var v= g * 0.15;

            var result = v + g;
            Console.WriteLine(Math.Truncate(result));

            }else
            {
                if(type=="normal")
                {
                    b = 48 - h;
                    var tp = b * 3.0 / 4;
                    var c = p * 2.0 / 3;
                    var g = tp + h + c;
                    

                    var result =  g;
                    Console.WriteLine(Math.Truncate(result));
                }
            }
        }
    }
}
