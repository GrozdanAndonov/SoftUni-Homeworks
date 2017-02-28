using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] mas1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] mas2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool areEqual = false;
            for (int i = 0; i < Math.Min(mas1.Length,mas2.Length); i++)
            {
                if (mas1[i] == mas2[i]) continue;
                else
                {
                    if(mas1[i]<mas2[i])
                    {
                        Console.WriteLine(mas1);
                        Console.WriteLine(mas2);
                    }
                    else
                    {
                        Console.WriteLine(mas2);
                        Console.WriteLine(mas1);
                    }
                    areEqual = true;
                    break;
                }

            }
            if (!areEqual)
            {
                if (mas1.Length <= mas2.Length)
                {
                    Console.WriteLine(mas1);
                    Console.WriteLine(mas2);
                }
                else
                {
                    Console.WriteLine(mas2);
                    Console.WriteLine(mas1);
                }
            }

        }
    }
}
