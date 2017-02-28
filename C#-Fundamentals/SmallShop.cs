using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower(); 
          var quantity = double.Parse(Console.ReadLine());
          String town1 = "plovdiv";
          String town2 = "sofia";
          String town3 = "varna"; 
            if(town==town2)
            {
                if(product=="coffee") Console.WriteLine(quantity*0.5);
                if (product == "water") Console.WriteLine(quantity * 0.8);
                if (product == "beer") Console.WriteLine(quantity * 1.2 );
                if (product == "sweets") Console.WriteLine(quantity * 1.45);
                if (product == "peanuts") Console.WriteLine(quantity * 1.60);
            }
            if (town == town1)
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.4);
                if (product == "water") Console.WriteLine(quantity * 0.7);
                if (product == "beer") Console.WriteLine(quantity * 1.15);
                if (product == "sweets") Console.WriteLine(quantity * 1.30);
                if (product == "peanuts") Console.WriteLine(quantity * 1.50);
            }
            if (town ==town3)
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.45);
                if (product == "water") Console.WriteLine(quantity * 0.7);
                if (product == "beer") Console.WriteLine(quantity * 1.1);
                if (product == "sweets") Console.WriteLine(quantity * 1.35);
                if (product == "peanuts") Console.WriteLine(quantity * 1.55);
            }


        }
    }
}
