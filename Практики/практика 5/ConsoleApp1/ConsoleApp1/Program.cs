using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int a;
            int b;
            int c;
            Console.WriteLine("Введите А");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                c = a;
                a = b;
                b = c;
            }
            c = a;
            while(c<=b)
            {
                if (c % 3 == 0)
                {
                    Console.WriteLine(c);
                }
                c++;
            }
        }
    }
}
