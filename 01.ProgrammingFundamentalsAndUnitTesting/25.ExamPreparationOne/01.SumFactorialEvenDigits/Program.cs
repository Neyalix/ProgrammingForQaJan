namespace _01.SumFactorialEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            //4532
            int sum = 0;
            while (number > 0)
            {
                int lastNumber = number % 10;

                if (lastNumber % 2 == 0)
                {
                    int currentNumber = FactorialLogic(lastNumber);
                    sum += currentNumber;
                }
                number /= 10;
            }
            Console.WriteLine(sum);
        }

        static int FactorialLogic(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
