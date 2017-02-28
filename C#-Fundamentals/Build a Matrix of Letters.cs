using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_Matrix_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            var matrix=new char[num1,num2];

            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);


            char letter = 'A';

            for(int row=0;row<rows;row++)
            {
                for (int col  = 0; col  <cols; col++)
                {
                    matrix[row, col] = letter;
                    letter++;
                    if (letter == 'Z') letter = 'A';
                }

            }

            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}
