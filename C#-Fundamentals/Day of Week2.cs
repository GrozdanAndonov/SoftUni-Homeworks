using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            String[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            switch(n)
            {
                case 1: Console.WriteLine(week[n-1]); break;
                case 2: Console.WriteLine(week[n - 1]); break;
                case 3: Console.WriteLine(week[n - 1]); break;
                case 4: Console.WriteLine(week[n - 1]); break;
                case 5: Console.WriteLine(week[n - 1]); break;
                case 6: Console.WriteLine(week[n - 1]); break;
                case 7: Console.WriteLine(week[n - 1]); break;
                default: Console.WriteLine("Invalid day!"); break;
            }

        }
    }
}
