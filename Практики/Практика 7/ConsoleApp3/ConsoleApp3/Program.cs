using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random rand = new Random();
            Console.WriteLine("Введите количство строк и столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] m1 = new int[m, m];
            int j,a2=0;
            int i,c = 0;
            int a1 = 0;
            for (i = 0; i < m1.GetLength(0); i++)
            {
                for (j = 0; j < m1.GetLength(1); j++)
                {
                    m1[i, j] = rand.Next(10);

                    Console.Write("{0,9} ", m1[i, j]);
                }
                Console.WriteLine();
            }
            for (i = 0; i < m1.GetLength(0); i++)
            {
                for (j = 0; j < m1.GetLength(1); j++)
                {
                    
                    if (a1 < m1[i, j])
                    {
                        a1 = m1[i, j];
                        a2 = j;
                    }



                }
                
                c = m1[i,i];
                m1[i, i] = a1;
                m1[i, a2] = c;
                a1 = 0;
            }
            Console.WriteLine(" ");
            for (i = 0; i < m1.GetLength(0); i++)
            {
                for (j = 0; j < m1.GetLength(1); j++)
                {
                    Console.Write("{0,9} ", m1[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
