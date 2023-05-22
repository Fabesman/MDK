using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int mmmmm = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Matrix n = new Matrix();
            while (mmmmm != 0)
            {
                Console.WriteLine("Доступные комманды:");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Ввод матрицы");
                Console.WriteLine("2 - Просмотр матрицы");
                Console.WriteLine("3 - Поиск столбца с максимальной суммой элементов");
                mmmmm = Convert.ToInt32(Console.ReadLine());
                switch(mmmmm)
                {
                    case 1:
                        Console.Clear();
                        n.One();
                        break;
                    case 2:
                        Console.Clear();
                        n.Two();
                        break;
                    case 3:
                        Console.Clear();
                        n.Tri();
                        break;
                    default:
                        Console.Clear();
                        if (mmmmm != 0)
                            Console.WriteLine("Введена неизвестная комманда, я умираю");
                        mmmmm = 0;
                        break;
                }
            }
        }
      
       
    }
    class Matrix
    {
        public int gg = 0;
        public int hh = 0;
        static public int[,] m1 = new int[GetB(),GetL()];
         static int GetB()
        {
            Console.WriteLine("Введите размерность матрицы а");
            int b = Convert.ToInt32(Console.ReadLine());
            return b;
        }
         static int GetL()
        {
            Console.WriteLine("Введите размерность матрицы б");
            int l = Convert.ToInt32(Console.ReadLine());
            return l;
        }
        public void One()
        {
            int a = 1;
            Console.WriteLine("1 - Рандом, не 1 - ручной ввод");
            a = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    if (a != 1)
                        m1[i, j] = Convert.ToInt32(Console.ReadLine());
                    else
                        m1[i, j] = rand.Next(50);
                }
                if (a != 1)
                    Console.WriteLine();
            }
            Console.WriteLine("Введите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();
        }
        public void Two()
        {
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    Console.Write("\t " + m1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();
        }

        public void Tri()
        {
            int c = 0;
            int max = int.MinValue;
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    c = c + m1[j, i];

                }
                if (c > max)
                    max = c;
                Console.WriteLine("Сумма элементов " + i + " столбца равна " + c);
                c = 0;
            }
            Console.WriteLine("Максимальная сумма элементов столбцов равна " + max);
            Console.WriteLine("Введите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
