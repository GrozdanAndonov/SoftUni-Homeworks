using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main()
        {

            var money = double.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice =double.Parse(Console.ReadLine());
            var eggsPrice = double.Parse(Console.ReadLine());
            var priceOfBerries = double.Parse(Console.ReadLine());




            var cook = 2 * bananaPrice + 4 * eggsPrice + priceOfBerries * 0.2;
            
            var numCooks=0;
            if(guests%6==0)
            {
                 numCooks = (guests / 6);
            }else
            {

                numCooks = guests / 6 + 1;
            }

            var endPrice = numCooks * cook;

            if (money >= endPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",endPrice);
            }
            else
            {
                if(money<endPrice)
                {
                    var num = endPrice - money;
                    Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",num);
                }
            }

        }
    }
}
