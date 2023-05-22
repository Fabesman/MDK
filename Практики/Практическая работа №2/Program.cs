using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1;
            int t2;
            int t3;
            int v1;
            int v2;
            int v3;
            int S1;
            int S2;
            int S3;
            int AllS;
            string l;

            Console.WriteLine("Введите t1");
            l = Console.ReadLine();
            t1 = Convert.ToInt32(l);
            Console.WriteLine("Введите v1");
            l = Console.ReadLine();
            v1 = Convert.ToInt32(l);
            Console.WriteLine("Введите t2");
            l = Console.ReadLine();
            t2 = Convert.ToInt32(l);
            Console.WriteLine("Введите v2");
            l = Console.ReadLine();
            v2 = Convert.ToInt32(l);
            Console.WriteLine("Введите t3");
            l = Console.ReadLine();
            t3 = Convert.ToInt32(l);
            Console.WriteLine("Введите v3");
            l = Console.ReadLine();
            v3 = Convert.ToInt32(l);
            S1 = v1 * t1;
            S2 = v2 * t2;
            S3 = v3 * t3;
            AllS = S1 + S2 + S3;
            Console.WriteLine("Первый путь = " + S1);
            Console.WriteLine("второй путь = " + S2);
            Console.WriteLine("третий путь = " + S3);
            Console.WriteLine("весь путь = " + AllS);
        }
    }
}
