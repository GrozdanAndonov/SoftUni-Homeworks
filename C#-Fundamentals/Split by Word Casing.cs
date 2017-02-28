using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = Console.ReadLine();

            var separators = ",;:.!()\"'/\\[] ".ToArray();
            var word = s.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            var lowerWords = new List<string>();
            var mixedWords = new List<string>();
            var upperWords = new List<string>();
            foreach (var w in word) 
            {
                var lowerLetter = 0;
                var upperLetter = 0;
                foreach (var letter in w)
                {
                    if (char.IsLower(letter)) lowerLetter++;
                    if (char.IsUpper(letter)) upperLetter++;

                }
                if (lowerLetter == w.Length) lowerWords.Add(w);
                else
                {
                    if (upperLetter == w.Length) { upperWords.Add(w); }
                    else
                        mixedWords.Add(w);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));



        }
    }
}
