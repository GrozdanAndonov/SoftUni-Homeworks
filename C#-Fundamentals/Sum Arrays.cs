using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var mas1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var mas2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var mas12 = new int[mas2.Length];
            var mas21 = new int[mas1.Length];
            if (mas1.Length > mas2.Length)
            {
                //kopirame masiva
                for (int i = 0; i < mas2.Length; i++)
                {
                    mas21[i] = mas2[i];
                }
                //udaljavame noviq masiv

                for (int i = 0; i < mas21.Length; i++)
                {
                    if (mas21[mas2.Length + i] == 0)
                    {
                        mas21[mas2.Length + i] = mas2[i];
                        if (mas21[i] == mas2.Length) i = 0;
                    }

                }
              

                for (int i = 0; i < mas1.Length; i++)
                {
                    mas21[i] = mas1[i] + mas21[i];
                }
                foreach (int nums in mas21) Console.Write(nums + " ");


            }
            ////////////////////////////////////////////////////////////////
            if (mas1.Length < mas2.Length)
            {
                //Kopirame masiva
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas12[i] = mas1[i];
                }
                //udaljavame noviq masiv

                for (int i = 0; i < mas12.Length - mas1.Length; i++)
                {
                    if (mas12[mas1.Length + i] == 0)
                    {
                        mas12[mas1.Length + i] = mas1[i];
                    }
                }

                for (int i = 0; i < mas2.Length; i++)
                {
                    mas12[i] = mas2[i] + mas12[i];
                }
                foreach (int nums in mas12) Console.Write(nums + " ");



            }
            ////////////////////////////////////////////////////////////////

            if (mas1.Length == mas2.Length)
            {
                for (int i = 0; i < mas1.Length; i++)
                {
                    mas12[i] = mas1[i] + mas2[i];
                }
                foreach (int nums in mas12) Console.Write(nums + " ");
            }














        }
       
    }
}

