namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4
            int countOfDays = int.Parse(Console.ReadLine());

            int totalAmountOfWater = 0;
            for (int i = 0; i < countOfDays; i++)
            {
               
                int millilitersOfWater = int.Parse(Console.ReadLine());
                totalAmountOfWater += millilitersOfWater;
                               
            Console.WriteLine(totalAmountOfWater);
            }
            if (countOfDays <= 0)
            {
                Console.WriteLine("0");
            }
                
        }
    }
}
