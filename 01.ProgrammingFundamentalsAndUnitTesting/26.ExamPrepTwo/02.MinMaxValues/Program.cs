using System.ComponentModel.DataAnnotations;

namespace _02.MinMaxValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();


            int n = int.Parse(Console.ReadLine());
            //numbers {3 42 61 7 8 9 10 23}

            int maxNum = numbers[0];
            int minNum = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }

            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);

        }
    }
}
