using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите количство столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количство строк");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] m1 = new int[m,n];
            int j;
            for (int i = 0;i<n;i++)
            {
                for( j = 0;j<m;j++)
                {
                    m1[j, i] = 10 * i;
                    Console.Write("{0,9} ",m1[j,i]);
                }
                Console.WriteLine();
            }
        }
    }
}
