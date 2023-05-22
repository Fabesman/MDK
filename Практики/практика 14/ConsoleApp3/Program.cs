using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opologize = "1";
            string not_opologize = "1";
            string a = null;
            int b;
            Console.ForegroundColor = ConsoleColor.Green;
            SingleLinkedList Deti = new SingleLinkedList();
            string q = null;
            string w = null;
            string e = null;
            int r = 0;
            int t = 0;
            while (opologize != "0")
            {
                Console.Clear();
                Console.WriteLine("Список комманд:");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Просмотр");
                Console.WriteLine("2 - Поиск по критерию");
                Console.WriteLine("3 - Вставква");
                Console.WriteLine("4 - Удаление");
                opologize = Console.ReadLine();
                switch (opologize)
                {
                    case "1":
                        Deti.Print();
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Список комманд:");
                        Console.WriteLine("0 - Назад");
                        Console.WriteLine("1 - По имени");
                        Console.WriteLine("2 - По адрессу");
                        Console.WriteLine("3 - По дате рождения");
                        Console.WriteLine("4 - По уровню");
                        not_opologize = Console.ReadLine();
                        switch (not_opologize)
                        {
                            case "1":
                                Console.WriteLine("Введите критерии поиска");
                                a = Console.ReadLine();
                                Deti.Print_poisk_name(a);
                                Console.WriteLine("Нажмите Enter для продолжения...");
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine("Введите критерии поиска");
                                a = Console.ReadLine();
                                Deti.Print_poisk_adress(a);
                                Console.WriteLine("Нажмите Enter для продолжения...");
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine("Введите критерии поиска");
                                a = Console.ReadLine();
                                Deti.Print_poisk_data(a);
                                Console.WriteLine("Нажмите Enter для продолжения...");
                                Console.ReadLine();
                                break;
                            case "4":
                                Console.WriteLine("Введите критерии поиска(1-5)");
                                try
                                {
                                    b = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Неизвестная комманда");
                                    break;
                                }
                                Deti.Print_poisk_level(b);
                                Console.WriteLine("Нажмите Enter для продолжения...");
                                Console.ReadLine();
                                break;
                            default:
                                if (not_opologize != "0")
                                {
                                    Console.WriteLine("Неизвестная комманда");
                                    Console.WriteLine("Нажмите Enter для продолжения...");
                                    Console.ReadLine();
                                }
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите номер поля после которого добавить елемент");
                        t = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите имя");
                        q = Console.ReadLine();
                        Console.WriteLine("Введите адресс");
                        w = Console.ReadLine();
                        Console.WriteLine("Введите дату");
                        e = Console.ReadLine();
                        Console.WriteLine("Введите уровень(1-5)");
                        r = Convert.ToInt32(Console.ReadLine());
                        Deti.Add_el_all(q,w,e,r,t);
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        break;
                    case "4":
                        Deti.No_el();
                        Console.WriteLine("Последний элемент удален");
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        break;
                    default:
                        if (opologize != "0")
                        {
                            Console.WriteLine("Неизвестная комманда");
                            Console.WriteLine("Нажмите Enter для продолжения...");
                            Console.ReadLine();
                        }
                        break;
                }
            }

        }
    }
    public class Node
    {
        private string NAME;
        private string ADRESS;
        private string DATA;
        private int LEVEL;
        private Node LINK;
        public string name
        {
            get { return NAME; }
            set { NAME = value; }
        }
        public string adress
        {
            get { return ADRESS; }
            set { ADRESS = value; }
        }
        public string data
        {
            get { return DATA; }
            set { DATA = value; }
        }
        public int level
        {
            get { return LEVEL; }
            set { LEVEL = value; }
        }
        public Node link
        {
            get { return LINK; }
            set { LINK = value; }
        }
        public Node()
        {

        }
        public Node(string NAME,string ADRESS, string DATA,int LEVEL)
        {
            NAME = name;
            ADRESS = adress;
            DATA = data;
            LEVEL = level;
        }
        public Node(string NAME, string ADRESS, string DATA, int LEVEL, Node LINK)
        {
            name = NAME;
            adress = ADRESS;
            data = DATA;
            level = LEVEL;
            link = LINK;
        }
    }
    public class SingleLinkedList
    {
        private Node FIRST;
        private Node LAST;
        public Node first
        {
            get { return FIRST; }
            set { FIRST = value; }
        }
        public Node last
        {
            get { return LAST; }
            set { LAST = value; }
        }
        public SingleLinkedList()
        {
            first = null;
        }
        public SingleLinkedList(string Name_el,string Adress_el,string Data_el,int Level_el)
        {
            Node p = new Node(Name_el,Adress_el,Data_el,Level_el);
            if (first == null)
                first = p;
            else
            {
                LAST.link = p;
                LAST = p;
            }
        }
        public void Add_el(string Name_el, string Adress_el, string Data_el, int Level_el)
        {
            Node p = new Node(Name_el, Adress_el, Data_el, Level_el);
            if (first == null)
            {
                first = p;
                first.link = null;
                last = first;
            }
            else
            {
                last.link = p;
                last = p;
            }
        }
        public void Add_el_all(string Name_el, string Adress_el, string Data_el, int Level_el, int node)
        {
            Node p = new Node(Name_el, Adress_el, Data_el, Level_el);
            int count = 0;
            p.name = Name_el;
            p.adress = Adress_el;
            p.data = Data_el;
            p.level = Level_el;
            Node temp = null;
            Node c = first;
            while (c != null)
            {
                c = c.link;
                count++;
            }
            c = first;
            if (first == null)
            {
                first = p;
                first.link = null;
                last = first;
            }
            else
            {
                if (node < count)
                {
                    for (int i = 0; i < node - 1; i++)
                        c = c.link;

                    temp = c.link;
                    c.link = p;
                    p.link = temp;
                   
                }
                else
                {
                    last.link = p;
                    last = p;
                }
            }


        }
        public void Print()
        {
            Node p = first;
            int count = 0;
            while(p != null)
            {
                count++;
                Console.WriteLine(count + "  "+ p.name +" "+ p.adress +" "+ p.data +" "+ p.level);
                p = p.link;
            }
        }
        public void Print_poisk_name(string a)
        {
            Node p = first;
            string ll;
            string kk;
            int count = 0;
            while (p != null)
            {
                count++;
                ll = p.name;
                kk = p.name;
                ll = ll.Replace(a,"111");
                if (ll != kk)
                    Console.WriteLine(count + "  " + p.name + " " + p.adress + " " + p.data + " " + p.level);
                p = p.link;
            }
        }
        public void Print_poisk_adress(string a)
        {
            Node p = first;
            string ll;
            string kk;
            int count = 0;
            while (p != null)
            {
                count++;
                ll = p.adress;
                kk = ll;
                ll = ll.Replace(a, "111");
                if (ll != kk)
                    Console.WriteLine(count + "  " + p.name + " " + p.adress + " " + p.data + " " + p.level);
                p = p.link;
            }
        }
        public void Print_poisk_data(string a)
        {
            Node p = first;
            string ll;
            string kk;
            int count = 0;
            while (p != null)
            {
                count++;
                ll = p.data;
                kk = ll;
                ll = ll.Replace(a, "111");
                if (ll != kk)
                    Console.WriteLine(count + "  " + p.name + " " + p.adress + " " + p.data + " " + p.level);
                p = p.link;
            }
        }
        public void Print_poisk_level(int a)
        {
            Node p = first;
            int count = 0;
            while (p != null)
            {
                count++;
                if (a == p.level)
                    Console.WriteLine(count + "  " + p.name + " " + p.adress + " " + p.data + " " + p.level);
                p = p.link;
            }
        }
        public void No_el()
        {
            Node p = new Node();
            if (first == null)
            {
            }
            else
            {
                last.link = null;
                last = null;
            }
        }
    }
    
}

