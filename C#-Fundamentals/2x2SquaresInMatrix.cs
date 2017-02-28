using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_x_2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var matrix = new char[nums[0], nums[1]];

            for (int row = 0; row < nums[0]; row++)
            {
                var line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < nums[1]; col++)
                {
                    
                    matrix[row, col] = line[col];
                }

            }
            int count = 0;
           
                for (int row = 0; row < nums[0]; row++)
                {
                    if (row + 1 == nums[0]) break;
                    for (int col = 0; col < nums[1]; col++)
                    {

                        if (col + 1 == nums[1]) break;
                        
                        if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                        
                    }
                }
                Console.WriteLine(count);
            
          
            

        }
    }
}
