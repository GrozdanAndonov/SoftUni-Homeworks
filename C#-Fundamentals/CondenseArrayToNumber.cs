using System;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenght=mas.Length;
            for (int a = 0; a < lenght - 1; a++)
            {
                int[] mas2 = new int[mas.Length - 1];
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    mas2[i] = mas[i] + mas[i + 1];
                }
                mas = mas2;
            }
            Console.WriteLine(mas[0]);
        }
    }
