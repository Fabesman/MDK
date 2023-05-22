using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int o;
            int Sum = 0;
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[n];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < n; i++)
                m1[i] = Convert.ToInt32(Console.ReadLine());
            int v = n-1;
            for (int i = 0; i*2 < n; i++)
            {
                o = m1[i];
                m1[i] = m1[v];
                m1[v] = o;
                v--;
            }
            for (int i = 0;i<n;i++)
            {
                Console.Write("{0,9} ", m1[i]);
                if(i%2 != 1)
                {
                    Sum = Sum + m1[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма нечетных элементов массива: " + Sum);
        }
    }
}
