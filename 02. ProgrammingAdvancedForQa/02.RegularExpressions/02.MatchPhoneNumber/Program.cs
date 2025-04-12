using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";

            

            MatchCollection match = Regex.Matches(input, pattern);

            List<string> list = new List<string>();

            foreach (Match matches in match)
            {
                list.Add(matches.Value);
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
