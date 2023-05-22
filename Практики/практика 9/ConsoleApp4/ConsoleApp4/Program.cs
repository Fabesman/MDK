using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            int n = s.Length;
            string m = " ";
            int BB = 0;
            int v = 0;
            string[] s1 = new string[100];
            for (int a = 0; a < n; a++)
            {
                if (s[a] == ' ')
                {
                    for (int y = BB; y < a- 1; y++)
                    {
                        m = m + s[y];
                    }
                    v++;
                    s1[v] = m;
                    BB = a ;
                }
            }
            if ( v <= 2)
            {
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < v; i++)
                {
                    Console.Write(s1[i]);
                    Console.Write(' ');
                }
            }
        }
    }
}
