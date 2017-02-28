using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predvaritelnot_kontrolno_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] names =new string[num];
            var sum=0;

            int grifindor = 0;
            int slytherin=0;
            int ravenclaw=0;
            int hufflepuff=0;



            for (int i = 0; i < num;i++ )
            {
                names[i] = Console.ReadLine();
            }

                for (int i = 0; i < num; i++)
                {
                 
                    sum = 0;
                    foreach (var ch in names[i])
                    {
                        if (ch != ' ') sum += ch;
                    }

                    string[] firstLastName = names[i].Split(' ');



                    if (sum % 4 == 0) { grifindor++; Console.WriteLine("Gryffindor {0}{1}{2}", sum, names[i][0], firstLastName[1][0]); }
                    if (sum % 4 == 1) { slytherin++; Console.WriteLine("Slytherin {0}{1}{2}", sum, names[i][0], firstLastName[1][0]); }
                    if (sum % 4 == 2) { ravenclaw++; Console.WriteLine("Ravenclaw {0}{1}{2}", sum, names[i][0], firstLastName[1][0]); }
                    if (sum % 4 == 3) { hufflepuff++; Console.WriteLine("Hufflepuff {0}{1}{2}", sum, names[i][0], firstLastName[1][0]); }
                }

                Console.WriteLine();


            Console.WriteLine("Gryffindor: {0}",grifindor);
            Console.WriteLine("Slytherin: {0}", slytherin);
            Console.WriteLine("Ravenclaw: {0}",ravenclaw);
            Console.WriteLine("Hufflepuff: {0}", hufflepuff);

        

        }
    }
}
