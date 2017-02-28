using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_a_Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();
                //line.Reverse();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }

            }
               var matrix2 = new string[cols, rows];


               for (int row = 0; row < cols; row++)
               {

                   for (int col = rows-1; col>=0; col--)
                   {

                       Console.Write("{0} ", matrix[col, row]);
                   }
                   Console.WriteLine();
               }

            //for (int row = 0; row < rows; row++)
            //{
               
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write("{0} ",matrix2[col, row]);
            //    }
            //    Console.WriteLine();
            //}
            


        }
    }
}
