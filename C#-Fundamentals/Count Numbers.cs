        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Count_Numbers
        {
                class Program
                {
                    static void Main(string[] args)
                    {

                        var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                        nums.Sort();


                        for (int start = 0; start < nums.Count; start++)
                        {
                            int count = 1;

                            while(start+count<nums.Count && nums[start]==nums[start+count])
                            {
                   
                                count++;
                            }
                            start += count-1;
                
                            Console.WriteLine("{0} -> {1}", nums[start], count);
                        }



                    }
            }
        }
