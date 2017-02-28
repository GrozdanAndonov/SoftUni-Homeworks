using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolnoZadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var line1 = Console.ReadLine().Split(' ');
            string[] line2=new string[100];
           
            for (int i = 0; i <line2.Length; i++)
            {
                line2[i] = Console.ReadLine();
                if (line2[i] == "End of customers!") break;
                line2[i].ToLower();
                line2[i].Split(' ');

            }
             string[] input=new string[100];

             for (int i = 0; i < 6; i++)
             {

                 input[i] = line2[i][0].ToString() + line2[i][9].ToString() + line2[i][10];
                 input[i].ToLower();
                 Console.WriteLine(input[i]);
             }




        }
    }
}
