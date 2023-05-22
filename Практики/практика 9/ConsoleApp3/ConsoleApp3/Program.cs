using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            int n = s1.Length;
            if(n <= 2)
            {
                Console.WriteLine();
            }
            else
            {
                for(int i = 1;i<n-1;i++)
                {
                    Console.Write(s1[i]);
                    Console.Write(' ');
                }
            }

        }
    }
}
