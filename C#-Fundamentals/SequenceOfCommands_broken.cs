using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("over"))
        {
            string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            if (command.Equals("add") ||
                command.Equals("substract") ||
                command.Equals("multiply"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(stringParams[0]);
                args[1] = int.Parse(stringParams[1]);

                PerformAction(array, command, args);
            }
            else if (command.Equals("lshift"))
            {

            }

            //PerformAction(array, command, args);

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

   public static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos-1] *= value;
                break;
            case "add":
                array[pos-1] += value;
                break;
            case "subtract":
                array[pos-1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
        return array;
    }

    public static long[] ArrayShiftRight(long[] array)
    {
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        return array;
    }

    public static long[] ArrayShiftLeft(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        return array;
    }

   public static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
