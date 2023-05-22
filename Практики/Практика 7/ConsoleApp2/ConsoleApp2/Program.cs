using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The World!");
            Random rand = new Random();
            Console.WriteLine("Введите количство столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количство строк");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] m1 = new int[m, n];
            int[] m2 = { -1, 0, 1 };
            int j, a, g = 0;
            int Sum = 0;
            int i;
            for (i = 0; i < m1.GetLength(0); i++)
            {
                for (j = 0; j < m1.GetLength(1); j++)
                {
                    a = rand.Next(3);
                    m1[i, j] = m2[a];

                    Console.Write("{0,3} ", m1[i, j]);
                }
                Console.WriteLine();
            }
            for(i = 0; i < m1.GetLength(1);i++)
            {
                for(j = 0; j < m1.GetLength(0);j++)
                {
                    if(m1[j,i] >= 0)
                    {
                        g = g + m1[j, i];
                    }
                    else
                    {
                        g = 0;
                        break;
                    }
                }
                Sum = Sum + g;
                g = 0;
                Console.WriteLine(Sum);
                Sum = 0;

            }
            Console.ReadLine();
        }
    }
}
