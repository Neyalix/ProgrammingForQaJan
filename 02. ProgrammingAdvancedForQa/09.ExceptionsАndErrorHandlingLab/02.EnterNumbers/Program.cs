namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int start = 1;

            while (numbers.Count < 10)
            {
                try
                {
                    int currentNum = ReadNumber(start, 100);
                    numbers.Add(currentNum);
                    start = currentNum;

                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine($"Your number is not in range {start} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }

        static int ReadNumber(int start, int end)
        {

            int n = int.Parse(Console.ReadLine());

            if (n <= start || n >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return n;
        }
    }
}
