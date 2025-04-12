
using System.Text.RegularExpressions;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();

            //string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            //MatchCollection match = Regex.Matches(input, pattern);

            //foreach (Match matches in match)
            //{
            //    Console.Write(matches.Value + " ");
            //}


            //string input = Console.ReadLine();

            //string pattern = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";

            //Regex regex = new Regex(pattern);

            //MatchCollection match = regex.Matches(input);

            //List<string> list = new List<string>();

            //foreach (Match matches in match)
            //{
            //    list.Add(matches.Value);
            //}
            //Console.Write(string.Join(", ", list));


            string input = Console.ReadLine();

            string pattern = @"[0-3]?[0-9]([./-])[A-Z][a-z]{2}\1\d{4}\b";

            MatchCollection match = Regex.Matches(input, pattern);

            List<string> list = new List<string>();

            foreach (Match matches in match)
            {
                list.Add(matches.Value);
            }
            Console.WriteLine(list);
        }
    }
}
