using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] mas1=new int[mas.Length/2];
            int[] mas2 = new int[mas.Length / 2];
            for (int i = 0; i < mas.Length/4; i++)
            {
                mas1[i] = mas[mas.Length / 4 - (i+1)];
            }
            int pos =mas.Length- (mas.Length / 2 + mas.Length / 4);
            for (int i = mas.Length-1; i > (mas.Length - mas.Length / 4)-1; i--)
            {
                mas1[pos] = mas[i];
                pos++;
            }
            for (int i = 0; i < mas.Length/2; i++)
            {
                mas2[i]=mas[(mas.Length/4)+i];
            }
            for (int i = 0; i < mas.Length/2; i++)
            {
                mas2[i] += mas1[i];
            }
            Console.WriteLine(string.Join(" ", mas2));
        }
    }
}
