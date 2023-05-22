using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string t = null;
            Console.WriteLine("Введите 1 - Ввести текст самостоятельно");
            Console.WriteLine("Введите 2 - Готовый текст");
            int PEREMENA = Convert.ToInt32(Console.ReadLine());
            if (PEREMENA == 2)
            {
                t = File.ReadAllText("E:\\Фабисович Никита Алексеевич\\практика 11\\txt.txt");
                Console.WriteLine(t);
            }
            if (PEREMENA == 1)
            {
                t = Console.ReadLine();
            }
            if (PEREMENA != 1 & PEREMENA!= 2)
            {
                Console.WriteLine("Введена неверная комманда, вводится готовый текст");
                t = File.ReadAllText("E:\\Фабисович Никита Алексеевич\\практика 11\\txt.txt");
                Console.WriteLine(t);
            }
            string[] s1 = t.Split(' ');
            int h = 0;
            int g = 0;
            Console.WriteLine("Введите искомые слова через enter");
            string l = Console.ReadLine();
            string q = Console.ReadLine();
            for(int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == l)
                    h++;
                if (s1[i] == q)
                    g++;
            }
            if (g == 0)
                Console.WriteLine("Слово \"" + q + "\" не найдено");
            else
            {
                Console.WriteLine(q + ": " + g);
            }
            if (h == 0)
                Console.WriteLine("Слово \"" + l + "\" не найдено");
            else
            {
                Console.WriteLine(l + ": " + h);
            }
        }
    }
}
