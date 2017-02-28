using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int a=0;          
            int c = 0;
            int f = 0;
            do
            {
                a = num % 10;               
                c =  a + c;
                num =num/ 10;
            }while(num>f);
            Console.WriteLine(c);
        }
    }
}
