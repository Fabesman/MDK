Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("The World!");
Random rand = new Random();
Console.WriteLine("Введите количство столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количство строк");
int m = Convert.ToInt32(Console.ReadLine());
int[,] m1 = new int[m, n];
int[] m2 = { -1, 0, 1 };
int j;
int a;
int Sum=0;
bool b = true;
int i;
for ( i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        a = rand.Next(3);
        m1[i, j] = m2[a] ;
        

        Console.Write("{0,3} ",m1[i, j]);
    }
    Console.WriteLine();
}
for (int x = 0; x < m;x++)
{
    b = true;
    j = -1;
    while (b=true)
    {
        j++;
        if (m1[x,j] > 0)
        {
            Sum = Sum + m1[x, j];

        }
        else
        {
            b = false;
        }
    }
}
Console.WriteLine(Sum);
Console.ReadLine();