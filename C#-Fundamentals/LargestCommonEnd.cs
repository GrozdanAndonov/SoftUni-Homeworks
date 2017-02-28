using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mas1 = Console.ReadLine().Split(' ').ToArray();
            string[] mas2 = Console.ReadLine().Split(' ').ToArray();
            int countLeft = 0;
            int countRight = 0;
            for (int i = 0; i < Math.Min(mas1.Length,mas2.Length); i++)
            {
                if (mas1[i] == mas2[i]) countLeft++;
                else break;
            }
            for (int i = 0; i < Math.Min(mas1.Length, mas2.Length); i++)
            {
                if (mas1[(mas1.Length - 1) - i] == mas2[(mas2.Length - 1) - i]) countRight++;
                else break;
            }
            if ((countRight == 0 && countLeft == 0)) Console.WriteLine("0");
            else
            {
                if (countLeft > countRight) Console.WriteLine(countLeft);
                else
                {
                    if (countRight > countLeft) Console.WriteLine(countRight);
                    else
                    {
                        if (countLeft == countRight) Console.WriteLine(countRight);
                    }
                }
            }
        }
    }
}
