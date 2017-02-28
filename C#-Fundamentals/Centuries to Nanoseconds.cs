using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cent =ulong.Parse(Console.ReadLine());
            ulong years = cent * 100;
            ulong days = (ulong) (years * 365.2422);
            ulong hours = days * 24;
            ulong min = hours * 60;
            ulong sec = min * 60;
            ulong milsec = sec * 1000;
            decimal micsec = (decimal)milsec * 1000;
            decimal nansec =(decimal) micsec * 1000;

            Console.Write("{0} centruties = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} miliseconds = {7} microseconds = {8} nanoseconds",cent,years,days,hours,min,sec,milsec,micsec,nansec);

        }
    }
}
