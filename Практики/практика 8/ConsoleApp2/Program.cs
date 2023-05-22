using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                m1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,9} ", m1[i]);
            }
            Console.WriteLine();
            int indx;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    indx = i;
                    for (int j = i; j < n; j++)
                    {
                        if (m1[j] < m1[indx] & j % 2 != 0)
                        {
                            indx = j;
                        }
                    }
                    if (m1[indx] == m1[i])
                        continue;
                    int temp = m1[i];
                    m1[i] = m1[indx];
                    m1[indx] = temp;
                    
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,9} ", m1[i]);
            }
        }
    }
}
