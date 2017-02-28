using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char ch1 = 'a';
            char ch2 = 'a';
            int n=1;
            var matrix = new string[nums[0], nums[1]];

            for (int row = 0; row < nums[0]; row++)
            {
               
                for (int col=0 ; col < nums[1]; col++)
                {
                    Console.Write("{0}{1}{0} ",ch1,ch2);
                    ch2++;
                }
                Console.WriteLine();
                ch1++;
                ch2 = 'a';
                n = 1;
                n+=row;
                ch2 += (char)n;
                
            }


        }
    }
}

