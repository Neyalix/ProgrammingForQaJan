double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double result1 = firstNumber +  secondNumber;
double result2 = firstNumber - secondNumber;
double result3 = firstNumber * secondNumber;
double result4 =  firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {result1:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {result2:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {result3:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {result4:F2}");
