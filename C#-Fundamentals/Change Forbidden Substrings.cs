using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Forbidden_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] str2 = Console.ReadLine().Split(' ').ToArray();

            foreach (var w in str2)
            {
                str = str.Replace(w, new string('*', w.Length));
            }
            Console.WriteLine(str);
        }
    }
}
