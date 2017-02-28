using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           bool[] mas = new bool[num+1];

            for(int i=2;i<=num;i++)
            {
                mas[i] = true;
            }

            for (int i = 2; i <=num; i++)
            {
                if(mas[i])
                {
                    Console.Write(i+" ");

                    int p = 2 * i;
                    while(p<=num)
                    {
                        mas[p] = false;
                        p = p + i;
                    }

                }


            }



        }
    }
}
