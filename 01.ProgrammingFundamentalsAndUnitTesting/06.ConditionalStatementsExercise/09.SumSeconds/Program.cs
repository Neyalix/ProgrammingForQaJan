
int sec1 = int.Parse(Console.ReadLine());
int sec2 = int.Parse(Console.ReadLine());
int sec3 = int.Parse(Console.ReadLine());

int sumOfSec = sec1 + sec2 + sec3;
int minutes = sumOfSec / 60;
int seconds = sumOfSec % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");