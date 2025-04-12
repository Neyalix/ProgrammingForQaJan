
namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                                   .Split(" ");
            string output = "";

            foreach (string word in text)
            {

            string repeat = "";
            for (int i = 0; i < word.Length; i++)
            {
                repeat += word;
            }
                output += repeat;
            }
            Console.Write(output);

        }
    }
}
