using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int i=0;
            
            while(i<list.Count-1)
            {

                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i+1);
                    i--;
                    if (i < 0) i = 0;
                }
                else i++;

            }

            Console.WriteLine(string.Join(" ", list));
















            //for(int i=0;i<list.Count-1;i++)
            //{
            //    if(list[i]==list[i+1])
            //    {
            //        list[i] += list[i + 1];
            //        list.RemoveAt(i + 1);
            //        i-=2;
            //        if (i < 0) i = -1;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", list));
        }
    }
}
