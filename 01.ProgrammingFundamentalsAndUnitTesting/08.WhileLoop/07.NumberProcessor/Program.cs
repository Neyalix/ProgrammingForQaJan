
int n = int.Parse(Console.ReadLine());

string command = Console.ReadLine();


while (command != "End")
{
     switch (command)
    {
        case "Inc":
            n++;
            break;
        case "Dec":
            n--;
            break;
    }
    command = Console.ReadLine();
}
Console.WriteLine(n);