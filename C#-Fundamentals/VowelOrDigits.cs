using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            string sth = Console.ReadLine().ToLower();

            if (sth == "a" || sth == "o" || sth == "u" || sth == "y" || sth == "i" || sth == "e") Console.WriteLine("vowel");
            else if (sth=="0" || sth == "1" || sth == "2" || sth == "3" || sth == "4" || sth == "5" || sth == "6" || sth == "7" || sth == "8" || sth == "9") Console.WriteLine("digit");
            else Console.WriteLine("other");
            

        }
    }
}
