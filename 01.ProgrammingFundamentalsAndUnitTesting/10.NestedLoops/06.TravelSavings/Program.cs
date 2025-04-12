
string destination = Console.ReadLine();

while (destination != "End")
{
    double neededMoney = double.Parse(Console.ReadLine());
    double sum = 0;

    while (sum < neededMoney)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        sum += currentMoney;

        Console.WriteLine($"Collected: {sum:F2}");
    }

    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
   
}