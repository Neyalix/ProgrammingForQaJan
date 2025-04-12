string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

int hotelSpring = 30;
int hotelSummer = 50;
int hotelFall = 20;
int hotelWinter = 40;

int campSpring = 10;
int campSummer = 30;
int campFall = 15;
int campWinter = 10;

double springDisc = 0.2;
double fallDisc = 0.3;
double winterDisc = 0.1;

double price = 0;

if(season == "Spring" && accommodationType == "Hotel")
{
    price = hotelSpring * days;
    price -= price * springDisc;
} 
else if (season == "Spring" && accommodationType == "Camping")
{
    price = campSpring * days;
    price -= price * springDisc;
}
if (season == "Summer" && accommodationType == "Hotel")
{
    price = hotelSummer * days;
} 
else if (season == "Summer" && accommodationType == "Camping")
{
    price = campSummer * days;
}
if (season == "Autumn" && accommodationType == "Hotel")
{
    price = hotelFall * days;
    price -= price * fallDisc;
} 
else if (season == "Autumn" && accommodationType == "Camping")
{
    price = campFall * days;
    price -= price * fallDisc;
}
if (season == "Winter" && accommodationType == "Hotel")
{
    price = hotelWinter * days;
    price -= price * winterDisc;

} 
else if (season == "Winter" && accommodationType == "Camping")
{
    price = campWinter * days;
    price -= price * winterDisc;
}

Console.WriteLine($"{price:f2}");