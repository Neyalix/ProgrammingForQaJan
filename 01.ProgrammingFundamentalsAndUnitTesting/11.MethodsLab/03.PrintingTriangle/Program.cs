
int n = int.Parse(Console.ReadLine());

PrintTriangle(n);

static void PrintTriangle(int n)
{
    for (int i = 1; i < n; i++)
    {
        PrintLine(1, i);
    }

    for (int i = n; i >= 1; i--)
    {
        PrintLine(1, i);
    }
}



static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}