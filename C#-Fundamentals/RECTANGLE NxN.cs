﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECTANGLE_NxN
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for(int i=0;i<num;i++)
            {
                Console.WriteLine(new string('*', num));
            }

        }
    }
}
