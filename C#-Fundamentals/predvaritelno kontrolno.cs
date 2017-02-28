using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predvaritelno_kontrolno
{
    class Program
    {
        static void Main(string[] args)
        {

            var usPrice = double.Parse(Console.ReadLine());
            var boxWeightUS = double.Parse(Console.ReadLine());
            var ukPrice = double.Parse(Console.ReadLine());
            var boxWeightUK = double.Parse(Console.ReadLine());
            var chPrice = double.Parse(Console.ReadLine());
            var boxWeightCH = double.Parse(Console.ReadLine());

            var a = usPrice / 0.58/boxWeightUS;
            var b = ukPrice / 0.41 / boxWeightUK;
            var c = chPrice * 0.27 / boxWeightCH;

            var max=0.0;
            var min=0.0;
            for (int i = 0; i < 3;i++)
            {
                if (a < b) min = a;
                if (b < c) min = b;
                if (c < a) min = c;

            }

               

            if (min == a) Console.WriteLine("US store. {0:f2} lv/kg", min);
            if (min == b) Console.WriteLine("UK store. {0:f2} lv/kg", min);
            if (min == c) Console.WriteLine("Chinese store. {0:f2} lv/kg", min);

            if (max < a) max = a;
            if (max < b) max = b;
            if (max < c) max = c;


            var dif = max - min;
         
            Console.WriteLine("Difference {0:f2} lv/kg",dif);
        }
    }
}
