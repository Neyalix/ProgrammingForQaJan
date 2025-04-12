
using System.Net.Http.Headers;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            SortedDictionary<int, int> numsOfOCcurences = new();

            foreach (var number in numbers)
            {

                if (numsOfOCcurences.ContainsKey(number))
                {
                numsOfOCcurences[number] += 1;

                }
                else
                {
                    numsOfOCcurences.Add(number, 1);
                }
            }

            foreach (var kvp in numsOfOCcurences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
