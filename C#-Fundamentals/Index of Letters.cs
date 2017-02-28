using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            char[] mas=new char[26];
            for (int i = 0; i < mas.Length; i++)
            {
              char ch=  Convert.ToChar(97 + i);
                mas[i] = ch;
            }
            for (int i = 0; i < word.Length; i++)
            {
                for (int a = 0; a < mas.Length; a++)
                {
                     if(word[i]==mas[a])
                     {
                         Console.WriteLine("{0} -> {1}",word[i],a);
                     }
                }
            }
        }
    }
