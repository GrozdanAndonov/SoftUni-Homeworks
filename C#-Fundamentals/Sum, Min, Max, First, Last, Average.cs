using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__First__Last__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            float[] mas = new float[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine(mas.Sum());
            Console.WriteLine(mas.Min());
            Console.WriteLine(mas.Max());
            Console.WriteLine(mas.First());
            Console.WriteLine(mas.Last());
            Console.WriteLine(mas.Average());


            //string str = Console.ReadLine();
            //string[] mas = str.Split(' ');

            //for (int i = 0; i < mas.Length; i++)
            //    Console.WriteLine(mas[i]);

        }
    }
}
