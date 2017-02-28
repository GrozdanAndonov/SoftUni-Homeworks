using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] input;
            int i = 0;
            for (int row = 0; row < 100; row++)
            {



                int pos1;
                int pos2;

                input = Console.ReadLine().Split(' ');
                if (input[0] == "end") break;
////////////////////////SWAP
                if (input[0] == "swap")
                {
                    pos1 = nums[Int32.Parse(input[0 + 1])];
                    pos2 = nums[Int32.Parse(input[0 + 2])];

                    nums[Int32.Parse(input[0 + 1])] = pos2;
                    nums[Int32.Parse(input[0 + 2])] = pos1;

                    //foreach (var num in nums)
                    //{
                    //    Console.Write("{0} ", num);
                    //}
                    //Console.WriteLine();
                }
///////////////////////////////////////SWAP
               
                if (input[0] == "multiply")
                {

                    pos1 = nums[Int32.Parse(input[0 + 1])] * nums[Int32.Parse(input[0 + 2])];
                    nums[Int32.Parse(input[0 + 1])] = pos1;
                    //foreach (var num in nums)
                    //{
                    //    Console.Write("{0} ", num);
                    //}
                    //Console.WriteLine();

                }

                if (input[0] == "decrease")
                {

                    for (int b = 0; b < nums.Length; b++)
                    {
                        nums[b] = nums[b] - 1;
                    }
                    //foreach (var num in nums)
                    //{
                    //    Console.Write("{0} ", num);
                    //}
                    //Console.WriteLine();                    
                }          
            }
           
            Console.Write(string.Join(", ", nums));


        }
    }
}
