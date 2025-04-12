

double balance = 0;

while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    double amountOfMopney = double.Parse(command);
    balance += amountOfMopney;
    if (amountOfMopney >= 0)
    {

        Console.WriteLine($"Increase: {amountOfMopney:F2}");
    }
    else if (amountOfMopney <= 0)
    {
        Console.WriteLine($"Decrease: {Math.Abs(amountOfMopney):F2}");
    }
   



}


Console.WriteLine($"Balance: {balance:F2}");