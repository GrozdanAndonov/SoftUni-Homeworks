using System;
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            int max = getMax(num1,num2,num3);
            Console.WriteLine(max);
        }
        static int getMax(int num1,int num2,int num3)
        {
            int maxNum = 0;
            if (num1 > num2 && num1 > num3)
            {
                maxNum = num1;
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    maxNum = num2;
                }
                else
                {
                    if (num3 > num1 && num3 > num2)
                    {
                        maxNum = num3;
                    }
                }            
            }
            return maxNum;
        }



    }

