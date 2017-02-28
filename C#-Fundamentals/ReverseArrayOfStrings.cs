using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] mas = Console.ReadLine().Split(' ').ToArray();

            int masLenght = mas.Length;

            mas = mas.Reverse().ToArray();

            foreach (var obj  in mas)
            {
                Console.Write("{0} ",obj);
            }

        }
    }
}
