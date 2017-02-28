using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            string[] names1=new string[num];
            int[] pointsMas=new int[num];
            int points = 0;
            int final = 0;
            int max = 0;
            for (int i = 0; i < num; i++)
            {
                final = 0;
                names1[i] = Console.ReadLine();
               
                points = int.Parse(Console.ReadLine());

                for (int n = 0; n < names1[i].Length; n++)
                {
                    if (names1[i][n] % 2 == 0)
                    {
                        final += names1[i][n];
                    }else
                    {
                        final -= names1[i][n];
                    }
                }
                final += points;
                pointsMas[i] = final;
                
            }
            int qq=0;
            string[] names2 = new string[num];
            for (int i = 0; i < num; i++)
            {
                if (pointsMas[i] >= max )
                {
                    qq=i;
                    max = pointsMas[i];
                    names2[i] = names1[i];
                }
            }
            int c = 0;
            for (int i = 0; i < pointsMas.Length; i++)
            {

                if(pointsMas[i]==pointsMas[i+1])
                {
                    c = i;
                }
            }


            Console.WriteLine("The winner is {0} - {1} points",names2[qq],max);



        }
    }
}
