using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comission
{
    class Program
    {
        static void Main(string[] args)
        {

            String city = Console.ReadLine().ToLower();
            var sell = double.Parse(Console.ReadLine());


            if (city == "sofia")
            {
                if (sell >= 0 && sell <= 500)
                {
                    Console.WriteLine("{0:f2}", sell * 0.05);
                }
                else
                {
                    if (sell > 500 && sell <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sell * 0.07);
                    }
                    else
                    {
                        if (sell > 1000 && sell <= 10000)
                        {
                            Console.WriteLine("{0:f2}", sell * 0.08);
                        }
                        else
                        {
                            if (sell > 10000)
                            {
                                Console.WriteLine("{0:f2}", sell * 0.12);
                            }
                            else
                            {
                                if (sell < 0)
                                {
                                    Console.WriteLine("error");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (city == "varna")
                {
                    if (sell >= 0 && sell <= 500)
                    {
                        Console.WriteLine("{0:f2}", sell * 0.045);
                    }
                    else
                    {
                        if (sell > 500 && sell <= 1000)
                        {
                            Console.WriteLine("{0:f2}", sell * 0.075);
                        }
                        else
                        {
                            if (sell > 1000 && sell <= 10000)
                            {
                                Console.WriteLine("{0:f2}", sell * 0.1);
                            }
                            else
                            {
                                if (sell > 10000)
                                {
                                    Console.WriteLine("{0:f2}", sell * 0.13);
                                }
                                else
                                {
                                    if (sell < 0)
                                    {
                                        Console.WriteLine("error");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (city == "plovdiv")
                    {
                        if (sell >= 0 && sell <= 500)
                        {
                            Console.WriteLine("{0:f2}", sell * 0.055);
                        }
                        else
                        {
                            if (sell > 500 && sell <= 1000)
                            {
                                Console.WriteLine("{0:f2}", sell * 0.08);
                            }
                            else
                            {
                                if (sell > 1000 && sell <= 10000)
                                {
                                    Console.WriteLine("{0:f2}", sell * 0.12);
                                }
                                else
                                {
                                    if (sell > 10000)
                                    {
                                        Console.WriteLine("{0:f2}",sell * 0.145);
                                    }else
                                    {
                                        if (sell < 0)
                                        {
                                            Console.WriteLine("error");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }


            }
        }
    }
}
