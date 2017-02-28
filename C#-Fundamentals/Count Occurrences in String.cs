using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrences_in_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();
            var pos = 0;
            int count = 0;
           while(true)
           {
               pos = str.IndexOf(str2,pos);
               
               if (pos == -1) break;


               count++;
               pos++;
           }
           Console.WriteLine(count);

        }
    }
}
