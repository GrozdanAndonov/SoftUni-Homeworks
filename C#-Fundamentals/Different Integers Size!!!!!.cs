using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            try
            {
                long num1 = Convert.ToInt64(num);
                Console.WriteLine("{0} can fit in:", num);
            }
            catch {  }

            try
            {
               sbyte num1 = Convert.ToSByte(num);
               Console.WriteLine("sbyte");
            }
            catch { }
            //==========================================================//
            try
            {
                byte num1 = Convert.ToByte(num);
                Console.WriteLine("* byte");
            }
            catch { }
            try
            {
                short num1 = Convert.ToInt16(num);
                Console.WriteLine("* short");
            }
            catch { }
            try
            {
                ushort num1 = Convert.ToUInt16(num);
                Console.WriteLine("* ushort");
            }
            catch { }
            try
            {
                int num1 = Convert.ToInt32(num);
                Console.WriteLine("* int");
            }
            catch { }
            try
            {
                uint num1 = Convert.ToUInt32(num);
                Console.WriteLine("* uint");
            }
            catch { }
            try
            {
                long num1 = Convert.ToInt64(num);
                Console.WriteLine("* long");
            }
            catch { Console.WriteLine("{0} can't fit in any type", num); }
            //try
            //{
            //    ulong num1 = Convert.ToUInt64(num);
            //    Console.WriteLine("* ulong");
            //}
            //catch { }
            //try
            //{
            //    decimal num1 = Convert.ToDecimal(num);
            //    Console.WriteLine("* decimal");
            //}
            //catch { Console.WriteLine("{0} can't fit in any type", num); }
                
            


        }
    }
}
/////Drugata reshena zadacha
using System;
using System.Numerics;

namespace _17.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (-128 <= input) && (input <= 127);
            bool isByte = (0 <= input) && (input <= 255);
            bool isShort = (-32768 <= input) && (input <= 32767);
            bool isUshort = (0 <= input) && (input <= 65535);
            bool isInt = (-2147483648 <= input) && (input <= 2147483647);
            bool isUint = (0 <= input) && (input <= 4294967295);
            bool isLong = (-9223372036854775808 <= input) && (input <= 9223372036854775807);

            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}