namespace _14.LoopsExPowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int p = int.Parse(Console.ReadLine());

                int tempN = n;
            for (int i = 1; i < p; i++)
            {
                tempN *= n;

            }
            Console.WriteLine(tempN);
        }
    }
}
