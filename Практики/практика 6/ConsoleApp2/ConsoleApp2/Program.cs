﻿using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[n];
            Console.WriteLine("Заполните массив");
            for (int i = 0;i<n;i++)
            {
             m1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int a1;
            int a2 = int.MaxValue;
            int c1=0;
            int c2=0;

            for(int i = 0; i<n-1;i++)
            {
                if(m1[i]>m1[i+1])
                a1 = m1[i] - m1[i +1];
                else
                a1 = m1[i + 1] - m1[i];
                if (a1 < a2)
                {
                    c1 = m1[i];
                    c2 = m1[i+1];
                    a2 = a1;
                }
            }
            if(c1<c2)
            Console.WriteLine(c1 + " , " + c2);
            else
                Console.WriteLine(c2 + " , " + c1);
        }
    }
}