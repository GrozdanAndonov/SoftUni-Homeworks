using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           
            
            for ( int ni=num1 ; ni <=num2 ; ni++)
            {
              char ch= Convert.ToChar(ni);
                Console.Write("{0} ",ch);
            }


        }
    }
}
