namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine()
                                              .Split(", ")
                                              .ToList();


            string text = Console.ReadLine();

            foreach (string wordToFilter in bannedWords)
            {
                string asterix = new string('*', wordToFilter.Length);

                text = text.Replace(wordToFilter, asterix);
            }
            Console.WriteLine(text);
        }
    }
}
