using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sumOfRotations=new int[mas.Length];
            int[] rotated2 = new int[mas.Length];

            for (int currentLocation = 0; currentLocation < rotations; currentLocation++)
            {
                int lastElement = mas[mas.Length - 1];
                for (int currentElement = mas.Length-1; currentElement > 0; currentElement--)
                {
                    mas[currentElement] = mas[currentElement - 1];
                }
                mas[0] = lastElement;
                for (int currentElement = 0; currentElement < mas.Length; currentElement++)
                {
                    sumOfRotations[currentElement] += mas[currentElement]; 
                }
            }
            Console.WriteLine(string.Join(" ",sumOfRotations));
        }
    }
}
