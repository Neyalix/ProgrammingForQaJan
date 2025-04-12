
int number = int.Parse(Console.ReadLine());

SignOfInteger(number);

static void SignOfInteger(int number)
{
    if (number <0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}