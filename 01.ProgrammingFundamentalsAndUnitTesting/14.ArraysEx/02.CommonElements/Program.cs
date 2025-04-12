namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = ReadIntArray();
            int[] secondArray = ReadIntArray();

            foreach (int num1 in firstArray)
            {
                foreach (int num2 in secondArray)
                {
                    if(num1 == num2)
                    {
                        Console.Write($"{num1} ");
                    }
                }

            }
        }

        private static int[] ReadIntArray()
        {
            return Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();
        }
    }
}
