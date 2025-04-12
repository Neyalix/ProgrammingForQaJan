
int n = int.Parse(Console.ReadLine());

int p = int.Parse(Console.ReadLine());
int result = n;

for (int i = 1; i < p; i++)
{
    result *= n;
}
Console.WriteLine(result);