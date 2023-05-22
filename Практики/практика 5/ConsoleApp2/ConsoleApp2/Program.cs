using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int c = 0;
            int a;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите количество товара");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                i++;
                Console.WriteLine("Введите стоимость " + i + " товара");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 1000)
                {
                    c = c + a;
                }
            }
            while (i < n);
            Console.WriteLine(c);
        }
    }
}
