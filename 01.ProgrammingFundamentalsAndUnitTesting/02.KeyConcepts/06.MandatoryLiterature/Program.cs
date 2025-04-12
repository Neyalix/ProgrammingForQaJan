int numOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int numOfDays =  int.Parse(Console.ReadLine());

double readTime = numOfPages / pagesPerHour;
readTime = readTime / numOfDays;
Console.WriteLine(Math.Floor(readTime));