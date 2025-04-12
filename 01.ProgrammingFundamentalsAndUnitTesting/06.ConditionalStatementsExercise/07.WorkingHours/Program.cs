
int hourOfDay = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

bool workingHours = hourOfDay >= 10 && hourOfDay <= 18;
bool offHours = hourOfDay < 10 && hourOfDay > 18;

if (dayOfWeek == "Sunday")
{
    Console.WriteLine("closed");
}
else if (dayOfWeek != "Sunday" && offHours != workingHours)
{
    Console.WriteLine("open");
} else
{
    Console.WriteLine("closed");
}
