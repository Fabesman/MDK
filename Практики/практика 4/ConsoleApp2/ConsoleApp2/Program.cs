using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int a;
            int b ;
            int c = 0;
            int a1 = 0;
            Console.WriteLine("Введите A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                a = c;
            }

            for(int c1=c; c1<b;c1++)
            {
                a1 = a1 + c1 * c1;
            }
            Console.WriteLine(a1);
        }
    }
}
