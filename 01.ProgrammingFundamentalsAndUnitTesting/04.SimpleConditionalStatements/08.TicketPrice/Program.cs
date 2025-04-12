string ticketType = Console.ReadLine();

double studentTicket = 1.00;
double regularTicket = 1.60;
string invalidType = "Invalid ticket type!";

if (ticketType == "student")
{
    Console.WriteLine($"${studentTicket:F2}");
}
else if (ticketType == "regular")
{
    Console.WriteLine($"${regularTicket:F2}");
}
else
{
    Console.WriteLine(invalidType);
}