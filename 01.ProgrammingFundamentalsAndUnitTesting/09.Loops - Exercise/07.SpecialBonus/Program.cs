
int stopNumber = int.Parse(Console.ReadLine());
double currentNumber = 0;
while (true)
{


    int number = int.Parse(Console.ReadLine());


    if (number == stopNumber)
    {
        Console.WriteLine(currentNumber * 1.20);
        break;
    }
    currentNumber = number;
}

