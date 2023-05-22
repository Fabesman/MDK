using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int uuu = -1;
            LinkedList<det_sad> f = new LinkedList<det_sad>();
            while(uuu != 0)
            {
                Console.Clear();
                Console.WriteLine("Доступные команды");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Добавление записей");
                Console.WriteLine("2 - Изменение записей");
                Console.WriteLine("3 - Просмотр записей");
                try
                {
                    uuu = Convert.ToInt32(Console.ReadLine());  
                }
                catch
                {
                    uuu = -1;
                    Console.WriteLine("Введена неизвестная программа");
                    Console.WriteLine("Введите Enter для продолжения...");
                    Console.ReadLine();
                    Console.Clear();
                }
                switch (uuu)
                {
                    case 1:
                        Console.Clear();
                        f.Add();
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
                        if (uuu != 0)
                            Console.WriteLine("Введена неизвестная команда");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        break;
                }
            }
        }

    }
    public struct det_sad
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
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T> : IEnumerable<T>
        {
            Node<T> head;
            Node<T> tail;
            int count;
            public void Add(T data)
            {
                Node<T> node = new Node<T>(data);

                if (Head == null)
                    Head = node;
                else
                    Tail.Next = node;
                Tail = node;

                Count1++;
            }
            // удаление элемента
            public bool Remove(T data)
            {
                Node<T> current = Head;
                Node<T> previous = null;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        // Если узел в середине или в конце
                        if (previous != null)
                        {
                            // убираем узел current, теперь previous ссылается не на current, а на current.Next
                            previous.Next = current.Next;

                            // Если current.Next не установлен, значит узел последний,
                            // изменяем переменную tail
                            if (current.Next == null)
                                Tail = previous;
                        }
                        else
                        {
                            // если удаляется первый элемент
                            // переустанавливаем значение head
                            Head = Head.Next;

                            // если после удаления список пуст, сбрасываем tail
                            if (Head == null)
                                Tail = null;
                        }
                        Count1--;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
                return false;
            }

            public int Count { get { return Count1; } }
            public bool IsEmpty { get { return Count1 == 0; } }

        public Node<T> Head { get => head; set => head = value; }
        public Node<T> Tail { get => tail; set => tail = value; }
        public int Count1 { get => count; set => count = value; }

        // очистка списка
        public void Clear()
            {
                Head = null;
                Tail = null;
                Count1 = 0;
            }
            // содержит ли список элемент
            public bool Contains(T data)
            {
                Node<T> current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                        return true;
                    current = current.Next;
                }
                return false;
            }
            // добвление в начало
            public void AppendFirst(T data)
            {
                Node<T> node = new Node<T>(data);
                node.Next = Head;
                Head = node;
                if (Count1 == 0)
                    Tail = Head;
                Count1++;
            }
            // реализация интерфейса IEnumerable
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                Node<T> current = Head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
    }
}