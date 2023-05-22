using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите что угодно");
            string s = Console.ReadLine();
            int n = s.Length;
            string l = null;
            for(int i = 0;i<n;i++)
            {
                l = l + s[i];
                l = l + ' ';
            }
            Console.WriteLine(l);
        }
    }
}
