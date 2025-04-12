
int n = int.Parse(Console.ReadLine());


int sum = 0;

for (int i = 1; i <= n; i++)
{
    sum += i;
    Console.Write(i);
    if (i < n)
    {
        Console.Write("+");
    }
}
Console.WriteLine($"={sum}");