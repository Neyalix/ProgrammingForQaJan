
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());


double negativeCount = 0;
if (num1 < 0)
{
    negativeCount++;
}
if (num2 < 0)
{
    negativeCount++;
}
if (num3 < 0)
{
    negativeCount++;
}
if (negativeCount == 0)
{
    Console.WriteLine("zero");
} 
else if (negativeCount == 1)
{
    Console.WriteLine("negative");
} 
else if (negativeCount == 2)
{
    Console.WriteLine("positive");
}