namespace _02.MiddleElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();

            int center = numbers.Length / 2;

            int[] ints = new int[2]{ numbers[center], numbers[center - 1] };
            double average = ints.Average();

            Console.WriteLine($"{average:F2}");


        }
    }
}
 