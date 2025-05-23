﻿using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>\d{2})([./-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match date in match)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
