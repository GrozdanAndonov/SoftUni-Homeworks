using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char ch = 'a';
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", ch + i);

            }


        }
    }
}
