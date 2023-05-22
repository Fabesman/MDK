Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите количство столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количство строк");
int m = Convert.ToInt32(Console.ReadLine());
int[,] m1 = new int[m, n];
int j;
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        if (i == 0)
        {
            m1[i, j] = 10 * rand.Next(3);
            
            
            
        }
        Console.Write(" "+ m1[i, j]);
    }
    Console.WriteLine();
}
Console.ReadLine();
