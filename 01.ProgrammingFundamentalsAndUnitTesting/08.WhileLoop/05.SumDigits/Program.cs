
int n = int.Parse(Console.ReadLine());

int sum = 0;

while ( n > 0)
{
    int lastNum = n % 10;
    sum += lastNum;
    n /= 10;
}
Console.WriteLine(sum);