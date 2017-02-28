using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duljinenKonvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var fromSize = Console.ReadLine().ToLower();
            var toSize = Console.ReadLine().ToLower();

            if (fromSize == "km")
            {
                num = num*1000;
            }
            else
            {
                if (fromSize == "cm")
                {
                    num = num / 100;
                }
                else
                {
                    if (fromSize == "mi")
                    {
                        num = num / 0.000621371192;
                    }
                    else
                    {
                        if (fromSize == "in")
                        {
                            num = num / 39.3700787;
                        }
                        else
                        {
                            if (fromSize == "kmjljl")
                            {
                                
                            }
                            else
                            {
                                if (fromSize == "ft")
                                {
                                    num = num / 3.2808399;
                                }
                                else
                                {
                                    if (fromSize == "yd")
                                    {
                                        num = num / 1.0936133;
                                    }
                                    else
                                    {
                                        if(fromSize=="m")
                                        {
                                            num = num;
                                        }else
                                        {
                                            if(fromSize=="mm")
                                            {
                                                num = num / 1000;
                                            }
                                        }
                                    }
                                }
                            }
                        }



                    }

                }
            }
    ///////////////////////////////////////////////////////////////////
            if (toSize == "mm")
            {
                num = num*1000;
                Console.WriteLine(num);
            }
            else
            {
                if (toSize == "cm")
                {
                    num = num * 100;
                    Console.WriteLine(num);
                }
                else
                {
                    if (toSize == "mi")
                    {
                        num = num * 0.000621371192;
                        Console.WriteLine(num);
                    }
                    else
                    {
                        if (toSize == "in")
                        {
                            num = num * 39.3700787;
                            Console.WriteLine(num);
                        }
                        else
                        {
                            if (toSize == "km")
                            {
                                num = num / 1000;
                                Console.WriteLine(num);
                            }
                            else
                            {
                                if (toSize == "ft")
                                {
                                    num = num * 3.2808399;
                                    Console.WriteLine(num);
                                }
                                else
                                {
                                    if (toSize == "yd")
                                    {
                                        num = num * 1.0936133;
                                        Console.WriteLine(num);
                                    }else
                                    {
                                        if(toSize=="m")
                                        {
                                            Console.WriteLine(num);
                                        }
                                    }
                                }
                            }
                        }



                    }

                }
            }







        }
    }
}
