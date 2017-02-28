using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_minuti
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            if(hour<=24 && hour>=0)
            {
                min += 15;
            }
            if (hour == 24 && min > 59)
            {
                
                hour++;
                hour = hour - 24;
            }
            
           
                if (min > 59 )
                {
                    hour++;
                    min = min - 60;
                    if (hour > 23 && min>0 )
                    {
                        hour = hour - 24;
                    }
                }
                if(hour==24 && min==0)
                {
                    hour = 0;
                }
                  
            
                     
                
            

            if (min < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, min);
            }
            else
            {
                if (hour == '0')
                {
                    Console.WriteLine("0{0}:{1}", hour, min);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hour, min);
                }
            }
        }
    }
}
