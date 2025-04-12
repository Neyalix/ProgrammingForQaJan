namespace _01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            try
            {

                if (n < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }

                double result = Math.Sqrt(n);
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
