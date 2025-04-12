using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match matches in match)
            {
                Console.Write(matches.Value + " ");
            }
        }
    }
}
