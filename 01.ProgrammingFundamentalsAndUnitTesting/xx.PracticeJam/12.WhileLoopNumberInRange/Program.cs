
namespace _12.WhileLoopNumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
           
           
            while (n < 1 || n > 100)
            {
                n = int.Parse(Console.ReadLine());
            }
                Console.WriteLine(n);
                           
        }
    }
}
