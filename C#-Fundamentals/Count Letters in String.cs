using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Letters_in_String
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = Console.ReadLine().ToLower();
            int[] counter = new int[str.Max() + 1];
            //BROI BUKVITE POOTDELNO
            foreach (char ch in str)
            {
                counter[ch]++;
            }
            //printira nenulevite poleta
            for(char ch=(char)0;ch<counter.Length;ch++)
            {
                if (counter[ch] != 0) Console.WriteLine("{0} -> {1}",ch,counter[ch]);
            }

        }
    }
}
