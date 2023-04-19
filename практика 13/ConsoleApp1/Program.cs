using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int ppp = 1;
        public static int c = 0;
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите размерность базы данных");
            int i = Convert.ToInt32(Console.ReadLine())-1;
            Person[] tom = new Person[i];
            int poiu = 1;
            int tryy;
            while (poiu !=0)
            {
                tryy = 1;
                while (tryy != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Доступные команды");
                    Console.WriteLine("0 - Выход");
                    Console.WriteLine("1 - Добавление записей");
                    Console.WriteLine("2 - Изменение записей");
                    Console.WriteLine("3 - Просмотр записей");
                    try
                    {
                        poiu = Convert.ToInt32(Console.ReadLine());
                        tryy = 0;
                    }
                    catch
                    {
                        Console.WriteLine("Введена неизвестная программа");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                switch (poiu)
                {
                    case 1:
                        Console.Clear();
                        Vodka(ref tom); 
                        break;
                    case 2:
                        Console.Clear();
                        Pustoi(ref tom);
                        break;
                    case 3:
                        Console.Clear();
                        See(ref tom);
                        break;
                    default:
                        if (poiu !=0)
                        Console.WriteLine("Введена неизвестная команда");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void Vodka(ref Person[] tom)
        {
            
            ppp += c;
            c = 0;
            for (int i = 0; i < ppp; i++)
            {
                if(tom[i].name ==null)
                {
                    Console.WriteLine("Введите ФИО");
                    tom[i].name = Console.ReadLine();
                    Console.WriteLine("Введите возраст");
                    tom[i].age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите адрес");
                    tom[i].adres = Console.ReadLine();
                    Console.WriteLine("Введите уровень");
                    tom[i].xz = Convert.ToInt32(Console.ReadLine());
                    c++;
                }
                Console.Clear();
            }
                Console.WriteLine("Введите Enter для продолжения...");
                Console.ReadLine();
                Console.Clear();
        }
        static void Pustoi(ref Person[] tom)
        {
            int i = -1;
            Console.WriteLine("Введите номер ячейки для полной замены");
            Console.WriteLine("Если вы не знаете номер введите (-1)");
            i = Convert.ToInt32(Console.ReadLine());
            if (tom[i].name == null& i!=-1)
                {
                    Console.WriteLine("Введите ФИО");
                    tom[i].name = Console.ReadLine();
                    Console.WriteLine("Введите возраст");
                    tom[i].age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите адрес");
                    tom[i].adres = Console.ReadLine();
                    Console.WriteLine("Введите уровень");
                    tom[i].xz = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Введите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();
        }
        static void See(ref Person[] tom)
        {
           
            int k = 100;
            int mx;
            int ll;
            string nh;
            bool jj;
            while (k != 0)
            {
                Console.Clear();
                Console.WriteLine("Доступные команды");
                Console.WriteLine("1 - Просмотр всех записей");
                Console.WriteLine("2 - Просмотр записей с фильтром");
                Console.WriteLine("3 - Выход");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.Clear();
                        for (int i = 0; i < ppp;i++)
                        {
                            Console.WriteLine("Номер в списке "+ i);
                            tom[i].Print();
                        }
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        mx = 1;
                        while (mx != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Доступные команды");
                            Console.WriteLine("1 - Сортировка по ФИО");
                            Console.WriteLine("2 - Сортировка по возрасту");
                            Console.WriteLine("3 - Сортировка по адресу");
                            Console.WriteLine("4 - Сортировка по уровню");
                            Console.WriteLine("5 - Обратно");
                            mx = Convert.ToInt32(Console.ReadLine());

                            switch (mx)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Введит искомое значение");
                                    nh = Console.ReadLine();
                                    for (int i = 0; i < ppp; i++)
                                    {
                                        jj = tom[i].name.Contains(nh);
                                        if (jj == true)
                                        {
                                            Console.WriteLine("Номер в списке " + i);
                                            tom[i].Print();
                                        }
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Введит искомое значение");
                                    ll = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < ppp; i++)
                                    {
                                        if (tom[i].age == ll)
                                        {
                                            Console.WriteLine("Номер в списке " + i);
                                            tom[i].Print();
                                        }
                                    }
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Введит искомое адрес");
                                    nh = Console.ReadLine();
                                    for (int i = 0; i < ppp; i++)
                                    {
                                        jj = tom[i].adres.Contains(nh);
                                        if (jj == true)
                                        {
                                            Console.WriteLine("Номер в списке " + i);
                                            tom[i].Print();
                                        }
                                    }
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Введит искомое значение(0-5)");
                                    ll = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < ppp; i++)
                                    {
                                        if (tom[i].xz == ll)
                                        {
                                            Console.WriteLine("Номер в списке " + i);
                                            tom[i].Print();
                                        }
                                    }
                                    Console.ReadLine();
                                    break;
                                default:
                                    mx = 0;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        k = 0;
                        break;
                    default:
                        Console.WriteLine("Введена неизвестная команда");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        k = 0;
                        break;
                }
                Console.WriteLine("Введите Enter для продолжения...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
    public struct Person
    {
        public string name;
        public int age;
        public string adres;
        public int xz;
        public void Print()
        {
            
            Console.WriteLine($"ФИО: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Адрес: {adres}");
            Console.WriteLine($"Уровень подготовки: {xz}");
            Console.WriteLine();
        }
    }   
}
