double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double tomatoSum = tomatoPrice * tomatoQuantity;
double cucumberSum = cucumberPrice * cucumberQuantity;

double totalSum = tomatoSum +  cucumberSum;
Console.WriteLine($"{totalSum:f2}");