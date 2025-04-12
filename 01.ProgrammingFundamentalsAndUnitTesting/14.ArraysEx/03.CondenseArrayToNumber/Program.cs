namespace _03.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();
            
            while (numbers.Length > 1)
            {
                int[] tempNumbers = new int[numbers.Length - 1];
                for (int i = 0; i < tempNumbers.Length; i++)
                {
                    int currentNum = numbers[i];
                    int nextNum = numbers[i + 1];
                    tempNumbers[i] = currentNum + nextNum;
                   
                }
                numbers = tempNumbers;

            }
                Console.WriteLine(numbers[0]);
           
            
           
        }
    }
}
