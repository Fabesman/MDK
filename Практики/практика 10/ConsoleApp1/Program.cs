using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = null;
            int k = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            while (k != 4)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Ввод данных");
                Console.WriteLine("2 - Просмотр данных");
                Console.WriteLine("3 - Обработка");
                Console.WriteLine("4 - Выход");
                k = Convert.ToInt32(Console.ReadLine());
                switch(k)
                {
                    case 1:
                        first(ref h);
                        break;
                    case 2:
                        two(h);
                        break;
                    case 3:
                        Tre(h);
                        break;
                    default:
                        if(k!=4)
                            Console.WriteLine("Введена неверная комманда");
                        k = 4;
                        break;
                }
            }
        }
        static string first(ref string h)
        {
            Console.Clear();
            Console.WriteLine("Введите строку слов, разделенных пробелами");
            h = Console.ReadLine();
            Console.WriteLine("Нажмите Enter, для продолжения");
            Console.ReadLine();
            Console.Clear();
            return h;
        }
        static void two(string h)
        {
            Console.Clear();
            Console.WriteLine("Сейчас занесена строка: ");
            Console.WriteLine(h);
            Console.WriteLine("Нажмите Enter, для продолжения");
            Console.ReadLine();
            Console.Clear();
            return;
        }
        static void Tre(string rab)
        {
            Console.Clear();
            int Max = int.MaxValue;
            int p;
            string[] s1 = rab.Split(' ');
            for (int i = 0; i < s1.Length; i++)
            {
                p = s1[i].Length;
                if (p < Max)
                    Max = p;
            }
            Console.WriteLine("Длинна самого короткого слова - " + Max);
            Console.WriteLine("Нажмите Enter, для продолжения");
            Console.ReadLine();
            Console.Clear();
            return;
        }
    }
}
