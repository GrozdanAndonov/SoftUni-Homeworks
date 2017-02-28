using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSUM
{
    class Program
    {
        static void Main(string[] args)
        {


            String str = Console.ReadLine().ToLower();

            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;
            var sum=0;
            for(int num=0;num<=str.Length-1;num++)
            {
                if(str[num]=='a')
                {
                    sum += a;
                }
                else
                {
                    if (str[num] == 'e')
                    {
                        sum += e;
                    }
                    else
                    {
                        if (str[num] == 'i')
                        {
                            sum += i;
                        }
                        else
                        {
                            if (str[num] == 'o')
                            {
                                sum += o;
                            }
                            else
                            {
                                if (str[num] == 'u')
                                {
                                    sum += u;
                                }
                            }
                        }
                    }
                }
                
            }



            Console.WriteLine(sum);

        }
    }
}
