double depAmount = double.Parse(Console.ReadLine());
int termOfDep = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine());

double accumulatedInterest = depAmount * (interestRate / 100);
accumulatedInterest = accumulatedInterest / 12;
double totalSum = depAmount + termOfDep * accumulatedInterest;

Console.WriteLine(totalSum);
