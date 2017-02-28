using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();


           for(int i=0;i<nums.Count-1;i++)
           {
               if (nums.Count == 1) break;
               else
               {
                   if (nums.Count == 2 && nums[i] != nums[i + 1]) break;
               }
               if(nums[i]==nums[i+1])
               {
                   nums[i] = nums[i] * 2;
                   nums.RemoveAt(i + 1);
                   i-=2;

                   if (i < 0) i = -1;

               }
               
           }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
