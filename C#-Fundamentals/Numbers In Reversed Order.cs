using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Numbers_In_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();
            int lenght = num.Length;
            //num.ToCharArray();
            //num.Reverse();
            //string rev = (string)num;
            //Console.WriteLine(rev);

            for (int i = lenght-1; i >= 0; i--)
            {
                Console.Write("{0}", num[i]);
            }

        }
    }
}
