using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
           float sMetersSec = 0;

            float sec2=(min*60f)+sec+(hours*3600f);
            sMetersSec = (float) meters / sec2;
            Console.WriteLine(sMetersSec);

            float sKMhour=0f;
            float kilometers =(float) meters / 1000f;
            float sec3 = hours*3600f+min*60f+sec;
            float hours2 = sec3 / 3600f;
            sKMhour =(float) kilometers / hours2;
          //  Console.WriteLine(sKMhour);
            Console.WriteLine(sKMhour);


            float sMilesHour = 0f;

            float miles = (float)meters / 1609f;
            
            sMilesHour =(float) miles / hours2;
            Console.WriteLine(sMilesHour);


        }
    }
}
