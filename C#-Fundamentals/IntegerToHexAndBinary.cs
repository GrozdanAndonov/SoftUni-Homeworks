using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            string myHexNum = num.ToString("X");
            Console.WriteLine(myHexNum);
            var binary=Convert.ToString(num,2);
            Console.WriteLine(binary);

        }
    }

