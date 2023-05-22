using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int N;
            int S;
            int HAHA;
            string l;
            Console.WriteLine("Посмейтесь над Петром и назовите длинну стороны квадратного пятна на его штанах");
            l = Console.ReadLine();
            A = Convert.ToInt32(l);
            S = A * A;
            Console.WriteLine("Введите во сколько раз площадь петна меньше центральной площади города");
            l = Console.ReadLine();
            N = Convert.ToInt32(l);
            HAHA = S * N;
            Console.WriteLine("Получается площадь центральной площади равна "+HAHA);

        }
    }
}
