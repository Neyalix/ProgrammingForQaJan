namespace _04.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadIntArray();


            int controlNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (numbers[i] + nextNumber == controlNumber)
                    {
                        Console.WriteLine($"{numbers[i]} {nextNumber}");
                        break;
                    }
                }
            }

        }

        static int[] ReadIntArray()
        {
            return Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();
        }
    }
}
