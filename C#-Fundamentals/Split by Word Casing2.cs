using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing2
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();
            char[] constrains = {',',';',':','.','!','(',')','"','/','\\','[',']',' ','\''};
           var text2= text.Split(constrains,StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase=new List<string>();
            List<string> upperCase=new List<string>();
            List<string> mixedCase=new List<string>();
            
            foreach (var word in text2)
            {
                var lowerCaseN = 0;
                var upperCaseN = 0;
                
                foreach (var ch in word)
                {
                    if (char.IsLower(ch)) lowerCaseN++;
                    else
                    if (char.IsUpper(ch)) upperCaseN++;
                    
                }
               
                if (lowerCaseN == word.Count()) lowerCase.Add(word);
                else
                {
                    if (upperCaseN == word.Count()) upperCase.Add(word);
                    else
                    {
                         mixedCase.Add(word);
                
                    }
                }

            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ",upperCase));
        }
    }
}
