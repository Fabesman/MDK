Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите предложение");
string s = Console.ReadLine();
int n = s.Length;
int p = 0;
string op;
int v = 1;
int u = 0;
for(int i = 0;i<n;i++)
{
    if (s[i] == ' ' )
    {
        u++;
        op = null;
        
        for(int j = p;j<i;j++)
        {
            op = op + s[j];
        }
        p = i +1;
        op = op + ' ';
        if(v != 1 || v != u)
        {
            Console.Write(op);
        }
        v++;
    }
}
