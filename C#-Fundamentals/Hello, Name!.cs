using System;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            greeting(name);
        }
        static void greeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }

