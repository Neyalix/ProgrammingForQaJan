
namespace _11.WhileLoopSumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                int lastNumber = n % 10;
                sum += lastNumber;
                n /= 10;
                
            }
                 Console.WriteLine(sum);
        }
                
    }
}
