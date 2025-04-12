double distance = double.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());
double speed = distance / time;
//double roundSpeed = Math.Round(speed, 2);
Console.WriteLine($"{speed:f2}");