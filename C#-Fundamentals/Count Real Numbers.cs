using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            

            var num = Console.ReadLine().Split(' ').Select(double.Parse).ToList();


            for (int i = 0; i < num.Count;i++ )
            {
                if (num[i] < 0) { num.RemoveAt(i); i--; }
            }

            //num.ToArray();
            //double[] mas = new double[num.Count];

            //for (int i = 0; i < num.Count; i++)
            //{
            //    mas[i] = num[num.Count - i];

            //}

            num.Reverse();
           if(num.Count==0)
           {
               Console.WriteLine("empty");
           }
           else
                Console.WriteLine(string.Join(" ", num));

        }
    }
}
