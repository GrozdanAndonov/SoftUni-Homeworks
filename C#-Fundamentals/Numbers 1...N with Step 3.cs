using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_1._._.N_with_Step_3
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n;i+=2)
            {

                    Console.WriteLine(num);           
                    num = num * 4;

                    
            }



        }
    }
}
