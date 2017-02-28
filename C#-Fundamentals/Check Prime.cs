using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int a=2;
            int i=0;
            int c=Convert.ToInt32(Math.Sqrt(num));
            if(num<2)
            {
                Console.WriteLine("false");
                return;
            }
        
            for(int b=2;b<=c;b++)
            {

                i = num % b;

                if(i==0 && num==b)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    Console.WriteLine("false");
                }

            }


           
        }
    }
}
