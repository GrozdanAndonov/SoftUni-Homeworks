using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolnoZadacha2
{
    class Program
    {
        static void Main(string[] args)
        {

            var km = int.Parse(Console.ReadLine());
            String time = Console.ReadLine();
            double price1=0;
            double price2=0;
            double price3=0;

            if(km<20)
            {
                //Taxi
               
                if(time=="day")
                {
                    price1 = km * 0.79+ 0.7;
                    Console.WriteLine("{0:f2}", price1);
                }
                else
                {
                    price1 = km * 0.9+0.7;
                    Console.WriteLine("{0:f2}", price1);
                }
            }

            ///////////////////////
            if (km >= 20 && km<100)
            {
                //AVTOBUS
                
                
                
                    price2 = km * 0.09;

                    Console.WriteLine("{0:f2}", price2);
                    
                    
            }

            //////VLAK
            if (km >=100)
            {
                //Taxi
                
                
                
                    price3 = km * 0.06;
                    Console.WriteLine("{0:f2}", price3);
            }

         //**   if(price1<price2 && price1<price3)
     //**       {
         //**       Console.WriteLine("{0:f2}", price1);
          //  }
          //  else
          //  {
           //     if(price2<price1 && price2<price3)
              //  {
              //      Console.WriteLine("{0:f2}", price2);
              //  }
              //  else
               // {
               //     if(price3<price1 && price3<price2)
                   // {
                //        Console.WriteLine("{0:f2}", price3);
                   // }
             //   }
          //  }
        }
    }
}
