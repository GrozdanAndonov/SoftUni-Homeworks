using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_figure
{
    class Program
    {
        static void Main(string[] args)
        {

            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            String wh = "";
            // first figure
            var x1 = 0;
            var x2 = 3 * h;
            var y1 = 0;
            var y2 = h;

            if (x > x1 && x < x2)
            {
                if (y > y1 && y < y2)
                {

                    wh = "inside";

                }
                else
                {
                    wh = "outside";
                }
            }
            else
            {
                wh = "outside";
            }

            if (x == x1 && (y <= y2 && y >= y1))
            {
                wh = "border";
            }
            else
            {
                if (y == y1 && (x <= x2 && x >= x1))
                {
                    wh = "border";
                }
                else
                {
                    if (y == y2 && (x <= x2 && x >= x1))
                    {
                        wh = "border";
                    }
                    else
                    {
                        if (x == x2 && (y >= y1 && y <= y2))
                        {
                            wh = "border";
                        }
                    }
                }
            }
            if (y == y2 && (x < (x2 - h) && x > (x1 + h)))
            {
                wh = "inside";
            }

            ////////////second figure
            var x3 = h;
            var x4 = 2 * h;
            var y3 = h;
            var y4 = 4 * h;
            String w = "";

            if (x > x3 && x < x4)
            {
                if (y > y3 && y < y4)
                {

                    w = "inside";

                }
                else
                {
                    w = "outside";
                }
            }
            else
            {
                w = "outside";
            }


            if (x == x3 && (y <= y4 && y >= y3))
            {
                w = "border";
            }
            else
            {
                if (y == y3 && (x <= x4 && x >= x3))
                {
                    w = "border";
                }
                else
                {
                    if (y == y4 && (x <= x4 && x >= x3))
                    {
                        w = "border";
                    }
                    else
                    {
                        if (x == x4 && (y >= y3 && y <= y4))
                        {
                            w = "border";
                        }
                    }
                }
            }



            String end = "";
            if (w == "inside" || wh == "inside")
            {
                end = "inside";
            }
            else
            {
                if (w == "border" || wh == "border")
                {
                    end = "border";
                }
                else
                {
                    end = "outside";
                }
            }

            Console.WriteLine(end);







            ////////////////////////////////////////////////
        }
    }
}
