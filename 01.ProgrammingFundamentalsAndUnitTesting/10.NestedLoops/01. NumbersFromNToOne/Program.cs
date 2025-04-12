
int n = int.Parse(Console.ReadLine());

for (int i = n; i >= 1; i--)
{
    for (int y = n; y >= i; y--)
    {
        Console.WriteLine(i);
        break;
    }
}