
namespace _03.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToList();

            for (int i = 0; i < n.Count; i++)
            {
                if(n[i] < 0)
                {
                    n.RemoveAt(i);
                    i--;
                }

              
            }
            n.Reverse();
            if (n.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", n));
            }
        }
    }
}
