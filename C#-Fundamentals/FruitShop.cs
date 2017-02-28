using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {

            String fruit = Console.ReadLine().ToLower();
            String day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "saturday" || day == "sunday")
            {
              
                if (fruit == "banana")
                {

                    Console.WriteLine("{0:f2}",quantity*2.7);
                }
                if (fruit == "apple")
                {
                    Console.WriteLine("{0:f2}", quantity * 1.25);
                }
                if (fruit == "orange")
                {
                    Console.WriteLine("{0:f2}", quantity * 0.90);
                }
                if(fruit=="grapefruit")
                {
                    Console.WriteLine("{0:f2}", quantity * 1.60);
                }
                if (fruit == "kiwi")
                {
                    Console.WriteLine("{0:f2}", quantity * 3);
                }
                if (fruit == "pineapple")
                {
                    Console.WriteLine("{0:f2}", quantity * 5.6);
                }
                if(fruit=="grapes")
                {
                    Console.WriteLine("{0:f2}", quantity * 4.2);
                }
            }
            else { 
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {

                    Console.WriteLine("{0:f2}", quantity * 2.5);
                }
                if (fruit == "apple")
                {
                    Console.WriteLine("{0:f2}", quantity * 1.2);
                }
                if (fruit == "orange")
                {
                    Console.WriteLine("{0:f2}", quantity * 0.85);
                }
                if (fruit == "grapefruit")
                {
                    Console.WriteLine("{0:f2}", quantity * 1.45);
                }
                if (fruit == "kiwi")
                {
                    Console.WriteLine("{0:f2}", quantity * 2.7);
                }
                if (fruit == "pineapple")
                {
                    Console.WriteLine("{0:f2}", quantity * 5.5);
                }
                if (fruit == "grapes")
                {
                    Console.WriteLine("{0:f2}", quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            }
           



        }
    }
}
