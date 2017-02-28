using System;


namespace _23.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(ifPrime(num));
        }
        static bool ifPrime(long num)
        {
            if (num <= 1) return false;
            int maxDiv =(int) Math.Sqrt(num);
               for (long i = 2; i <= maxDiv; i++)
                {

                    if (num % i == 0)
                    {
                        return false;
                    }                 
                }              
              return true;
            }
        }

        }
    

