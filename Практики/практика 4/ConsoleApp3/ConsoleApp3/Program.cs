﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[n];
            int o =0;
            int SumO = 0;
            int Arr;
            int a=1;
            for (int i = 0; i < n; i++)
            {
                m1[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i = 0;i<n;i++)
            {
                if(m1[i]< 0)
                {
                    o++;
                    SumO = SumO + m1[i];

                }
                if(m1[i]>0)
                {
                    a = a * m1[i];
                }
            }
            Arr = SumO / o;
            Console.WriteLine("Среднее арифметическое отрицательных чисел: " + Arr);
            Console.WriteLine("Произведение положительных чисел: " + a);
        }
    }
}
