
int temperature = int.Parse(Console.ReadLine());

string timeOfDay = Console.ReadLine();

string outfit = "Shirt";
string shoes = "Moccasins";

if (temperature >=10 && temperature <= 18 && timeOfDay == "Morning")
{
    outfit = "Sweatshirt";
    shoes = "Sneakers";
}
else if (temperature >= 25 && timeOfDay == "Afternoon")
{
    outfit = "Swim Suit";
    shoes = "Barefoot";
}
else if (temperature > 18 && temperature <= 24 && timeOfDay == "Afternoon" || temperature >= 25 && timeOfDay == "Morning")
{
    outfit = "T-Shirt";
    shoes = "Sandals";
}
Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");