using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите размерностиь массива");
            int n = Convert.ToInt32(Console.ReadLine()) ;
            int[] m = new int[n];
            Console.WriteLine("Заполните массив числовыми значениями" +
                " отделяя их с помощью enter");
            for (int nn = 0;nn<n;nn++)
            {
                m[nn] = Convert.ToInt32(Console.ReadLine());
            }
            int i;
            int a= 0;
            int c = 0;
            for (i = 0; i < n; i++)
            {
                if(i==0 || a%2 == 0 & m[i]%2 !=0 || a % 2 != 0 & m[i] % 2 == 0)
                {
                    a = m[i];
                    continue;
                }
                else
                {
                    c = 1;
                    Console.WriteLine("не чередуются");
                    Console.WriteLine(i+1);
                    break;
                } 
            }
            if (c == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
