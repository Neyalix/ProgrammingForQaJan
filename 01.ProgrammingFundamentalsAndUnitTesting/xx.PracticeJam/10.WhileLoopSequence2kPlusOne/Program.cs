namespace _10.WhileLoopSequence2kPlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;

            int endNumber = int.Parse(Console.ReadLine());

            while (start <= endNumber)
            {
            int nextNumber = (start * 2) + 1;
                Console.WriteLine(start);
                start = nextNumber;
            }
           
        }
    }
}
