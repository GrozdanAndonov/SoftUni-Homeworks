using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int[] mas2=new int[100];
            for (int i = 0; i < mas.Length; i++)
            {
                count = 0;
                for (int a = 0; a < mas.Length; a++)
                {
                    if (mas[i] == mas[a])
                    {
                        count++;
                        if (mas2[count] == 0) mas2[count] = mas[i];
                    }
                }
            }
            Console.WriteLine("{0}", mas2[count]);
        }
    }