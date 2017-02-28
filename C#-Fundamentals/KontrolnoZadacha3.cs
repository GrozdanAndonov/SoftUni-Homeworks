using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolnoZadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            //chas na izpita 
            var h1 = int.Parse(Console.ReadLine());
            var m1 = int.Parse(Console.ReadLine());
            //chas na pristigane
            var h2 = int.Parse(Console.ReadLine());
            var m2 = int.Parse(Console.ReadLine());

            if(h1==h2 && m1==m2)
            {
                Console.WriteLine("On time");

            }else
            {
                if(h1==h2 && m1 != m2)
                {
                    if (m1 == 00) m1 = 60;
                    if (m2 == 00) m2 = 60;
                    int num = Math.Max(m1, m2) - Math.Min(m1, m2);
                    if(m1>m2)
                    {
                        if(num<=30)
                        {
                            Console.WriteLine("On time");
                            Console.WriteLine("{0} minutes before the start", num);
                        }
                        Console.WriteLine("Early");
                        Console.WriteLine("{0} minutes before the start", num);
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0} minutes after the start", num);
                    }
                }else
                {
                    if(h1!=h2 && m1==m2)
                    {
                        int num = Math.Max(h1, h2) - Math.Min(h1,h2);
                        if(h1<h2)
                        {
                            Console.WriteLine("Late");
                            Console.WriteLine("{0}:00 hours after the start",num);
                        }else
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine("{0}:00 hours before the start", num);
                        }
                    }
                    else
                    {
                        if(h1!=h2 && m1!=m2)
                        {
                            if (m1 == 00) m1 = 60;
                            if (m2 == 00) m2 = 60;
                            int num1 = Math.Max(h1, h2) - Math.Min(h1, h2);
                            int num2 = Math.Max(m1,m2) - Math.Min(m1,m2);

                            if(h1>h2)
                            {

                                if (num2 <= 30)
                                {
                                    Console.WriteLine("On time");
                                    Console.WriteLine("{0} minutes before the start", num2);
                                    return;
                                }
                                Console.WriteLine("Early");
                                if (num2 < 10)
                                {
                                    Console.WriteLine("{0}:0{1} hours before the start",num1,num2);
                                } else
                                {
                                    Console.WriteLine("{0}:{1} hours before the start",num1,num2);
                                }

                            }
                            else
                            {

                                Console.WriteLine("Late");
                                if (num2 < 10)
                                {
                                    Console.WriteLine("{0}:0{1} hours after the start",num1,num2);
                                }
                                else
                                {
                                    Console.WriteLine("{0}:{1} hours after the start",num1,num2);
                                }
                                Console.WriteLine("{0}:{1} hours after the start", num1, num2);

                            }


                        }
                    }
                }
            }
            





        }
    }
}
