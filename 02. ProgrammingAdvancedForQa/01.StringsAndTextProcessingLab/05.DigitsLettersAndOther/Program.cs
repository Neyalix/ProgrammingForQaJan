using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder symbol = new StringBuilder();

            foreach (char item in input)
            {
                if (char.IsDigit(item))
                {
                    digit.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    letter.Append(item);
                }
                else
                {
                    symbol.Append(item);
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(symbol);
        }
    }
}
