namespace _02.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] millimetersPerDay = Console.ReadLine()
                                             .Split(" ")
                                             .Select(int.Parse)
                                             .ToArray();


            int startDay = int.Parse(Console.ReadLine());
            int endDay = int.Parse(Console.ReadLine());

            double totalRainfall = 0.0;
            double averageRainfall = 0.0;

            for (int i = startDay; i <= endDay ; i++)
            {
                totalRainfall += millimetersPerDay[i];
            }
        
            averageRainfall = totalRainfall / (endDay - startDay + 1);

            Console.WriteLine($"{totalRainfall}");
            Console.WriteLine($"{averageRainfall:F2}");
        }
    }
}
