using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите что угодно");
            string s = Console.ReadLine();
            Console.WriteLine(String.Join(" ", s.ToCharArray()));
        }
    }
}
