using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] rowAndCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            int[,] matrix = new int[rows, cols];

            for(int row=0;row<rows;row++)
            {
                int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }

            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = coordinates[0];
            int y = coordinates[1];

            int num = 0;

            int startRow = Math.Max(0, x - 1);
            int endRow = Math.Min(rows - 1, x + 1);

            int startCol = Math.Max(0, y - 1);
            int endCol = Math.Min(cols - 1, y + 1);
            int midd = matrix[x, y];

            for (int row = startRow; row <=endRow ; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    num = num + matrix[row, col];
                }
            }

            num = num - midd;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    matrix[row, col] *= midd;
                }
            }
            matrix[x, y] = midd * num;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                    Console.WriteLine(matrix[row, cols - 1]);
                
            }


        }
    }
}
