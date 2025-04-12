namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();


            Dictionary<char, int> countOfString = new();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == ' ')
                {
                    continue;
                }

                if (!countOfString.ContainsKey(currentChar))
                {
                    countOfString.Add(currentChar, 1);
                }
                else
                {
                    countOfString[currentChar]++;
                }
;            }

            foreach (var kvp in countOfString)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
