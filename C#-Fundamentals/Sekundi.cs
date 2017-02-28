using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekundi
{
    class Program
    {
        static void Main(string[] args)
        {

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            int sum= num1 + num2 + num3;
            int min = sum / 60;
            int  sec = sum - min * 60;
            if (sum >= 60)
            {
               
                
                if (sec < 10)
                {
                    Console.WriteLine("{0}:0{1}", min, sec);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", min, sec);
                }
            }
            else
            {
                if (sec < 10)
                {
                    Console.WriteLine("{0}:0{1}", min, sec);
                }
                else
                {
                    Console.WriteLine("0:{0}", sum);
                }
            }


        }
    }
}
