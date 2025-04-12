
int n = int.Parse(Console.ReadLine());

double divisibleByTwo = 0;
double divisibleByThree = 0;
double divisibleByFour = 0;

for (int i = 0; i < n; i++)
{

    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
    {
        divisibleByTwo++;
    }
    if (currentNumber % 3 == 0)
    {
        divisibleByThree++;
    }
    if (currentNumber % 4 == 0)
    {
        divisibleByFour++;
    }
}

double divisibleByTwoPercentage = (divisibleByTwo / n) * 100;
double divisibleByThreePercentage = (divisibleByThree / n) * 100;
double divisibleByFourPercentage = (divisibleByFour / n) * 100;

Console.WriteLine($"{divisibleByTwoPercentage:f2}%");
Console.WriteLine($"{divisibleByThreePercentage:f2}%");
Console.WriteLine($"{divisibleByFourPercentage:f2}%");