using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want?");
            var a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                var points = double.Parse(Console.ReadLine());
                double bonus = 0;
                if (points <= 100)
                {
                    bonus = bonus + 5;
                    if (points % 2 == 0)
                    {
                        bonus++;
                    }
                    if (points % 10 == 5)
                    {
                        bonus += 2;
                    }
                    points = points + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points);
                }
                else
                {
                    if (points > 100 && points <= 1000)
                    {
                        bonus = points * 0.2;
                        if (points % 2 == 0)
                        {
                            bonus++;
                        }
                        if (points % 10 == 5)
                        {
                            bonus += 2;
                        }
                        points = points + bonus;
                        Console.WriteLine(bonus);
                        Console.WriteLine(points);
                    }
                    else
                    {
                        if (points > 1000)
                        {
                            bonus = points * 0.1;
                            if (points % 2 == 0)
                            {
                                bonus++;
                            }
                            if (points % 10 == 5)
                            {
                                bonus += 2;
                            }
                            points = points + bonus;
                            Console.WriteLine(bonus);
                            Console.WriteLine(points);
                        }
                    }
                }
            }
        }
    }
}



