using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int rows;
            int stars = 1;
            int hyphens;
            int mid = -1;
            if(n%2==0)
            {
                hyphens = (n - 2) / 2;
                rows=n/2;
                stars = 2;
                mid = 0;
            }else{
                rows=n/2+1;
                hyphens = (n - 1) / 2;
            }

            for(int num=1;num<=rows;num++)
            {

               

                if(num==1)
                {
                    Console.Write(new string('-', hyphens));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', hyphens));
                    stars = 2;
                   mid= mid + 2;
                }else
                {
                    hyphens--;
                    Console.Write(new string('-', hyphens));
                    Console.Write("*");
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                    Console.Write(new string('-', hyphens));
                    mid = mid + 2;
                }
                


                Console.WriteLine();

            }
            hyphens = 1;
            mid = n-4;
            hyphens = (n - 2 - mid) / 2;
            for(int num=1;num<(n+1)/2;num++)
            {
               
             

                if (num == ((n + 1) / 2)-1)
                {
                    if (n % 2 == 0)
                    {
                        stars = 2; hyphens = (n - 2-mid) / 2;
                    }
                    else
                    {
                        stars = 1; hyphens = (n - 1-mid) / 2;
                    }
                   
                    Console.Write(new string('-', hyphens));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', hyphens));
                    
                }
                else
                {
                    
                   

                    Console.Write(new string('-', hyphens));
                    Console.Write("*");
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                    Console.Write(new string('-', hyphens));
                    Console.WriteLine();
                    mid-=2;
                    hyphens++;
                }



            }




        }
    }
}
