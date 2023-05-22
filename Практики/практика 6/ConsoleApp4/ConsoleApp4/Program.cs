using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] m1 = new double[n];
            for(int i = 0;i < m1.Length- 1;i++)
            {
                m1[i] = Math.Pow(2,i+1);
            }
            for(int a = 0;a < m1.Length- 1;a++)
            {
                Console.WriteLine(m1[a]);
            }
        }
    }
}
