using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m1 = { 100, 200, 300, 400 };
            int a1 = 0;
            Array.Sort(m1);
            a1 = m1[0]; 
            m1[0]=m1[m1.Length-1];
            m1[0]=a1;
        }
    }
}
