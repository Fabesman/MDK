﻿using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[n];
            int max = int.MaxValue;
            int c;
            int t=0;
            int k=0;
            int min = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                m1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i<n;i++)
            {
                Console.Write("{0,9} ", m1[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                if (m1[j] < max)
                {
                    max = m1[j];
                    k = j;
                }
                if (m1[j] > min)
                {
                    min = m1[j];
                    t = j;
                }

            }
            c = m1[k];
            m1[k] = m1[t];
            m1[t] = c;
            for(int i = 0;i<n;i++)
            {
                Console.Write("{0,9} ", m1[i]);
            }

        }
    }
}
