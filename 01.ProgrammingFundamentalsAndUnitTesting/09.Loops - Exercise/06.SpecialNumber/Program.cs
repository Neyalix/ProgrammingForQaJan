
int n = int.Parse(Console.ReadLine());

bool isSpecial = true;
int currentNumber = n;
while (n > 0)
{
    int lastNum = n % 10;
    if (currentNumber % lastNum != 0)
    {
        isSpecial = false;
        break;
    }

    n /= 10;
}
if (isSpecial)
{
    Console.WriteLine($"{currentNumber} is special");
}
else
{
    Console.WriteLine($"{currentNumber} is not special");
}

