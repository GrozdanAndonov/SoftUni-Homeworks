using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenght = 0;
            int max=0;
            int pos = 0;
            for (int i = 1; i < mas.Length-1; i++)
            {
                if (mas[i-1] == mas[(i-1) + 1])
                {
                    lenght++;
                    if (lenght > max)
                    {
                        max = lenght;
                        pos = i - lenght;
                    }
                }
                else lenght = 0;
            }

            
                for (int i = pos; i <= pos + max + 1; i++)
                {
                    Console.Write("{0} ", mas[i]);
                }
                Console.WriteLine();
            
        }
    }
}
