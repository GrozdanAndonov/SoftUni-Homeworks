using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ednakvi_dvoiki
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            int b = 0;
            int equals=0;
          

/*************************** 1va dvoika *******************************/
              
                
                    for (int a = 1; a <= 2; a++)
                    {
                        var num2 = int.Parse(Console.ReadLine());

                        sum1 += num2;

                    }
                
/*************************** 1va dvoika *******************************/

                    for (int num1 = 0; num1 < num; num1++)
                    {

                        for (int a = 1; a <= 2; a++)
                        {
                            var num2 = int.Parse(Console.ReadLine());

                            sum += num2;

                        }

                       int razlika= sum1-sum;
                       if(razlika==0)
                       {
                            equals++;
                       }else
                       {
                           equals--;
                       }

                    }

               


            
            if(b==0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }else
            {
                Console.WriteLine("No, maxdiff={0}", b);
            }


        }
    }
}
