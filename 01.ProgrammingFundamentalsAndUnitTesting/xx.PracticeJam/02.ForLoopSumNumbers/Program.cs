namespace _02.ForLoopSumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double floatingN = double.Parse(Console.ReadLine());
                sum += floatingN;
            }
            Console.WriteLine(sum);
        }
    }
}
