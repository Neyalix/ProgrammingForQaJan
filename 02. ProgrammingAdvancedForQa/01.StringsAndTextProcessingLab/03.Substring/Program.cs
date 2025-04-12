namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputToRemove = Console.ReadLine();

            string toRemoveFrom = Console.ReadLine();

            while (toRemoveFrom.Contains(inputToRemove))
            {
                int startIndex = toRemoveFrom.IndexOf(inputToRemove);

                toRemoveFrom = toRemoveFrom.Remove(startIndex, inputToRemove.Length);
            }
            Console.WriteLine(toRemoveFrom);
        }
    }
}
