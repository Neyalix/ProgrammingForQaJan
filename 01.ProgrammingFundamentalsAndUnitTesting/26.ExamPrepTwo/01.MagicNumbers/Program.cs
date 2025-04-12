namespace _01.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool foundMagicNumber = false;

            for (int i = 1; i <= n; i++)
            {
                if (IsMagicNumber(i))
                {
                    Console.Write(i + " ");
                    foundMagicNumber = true;
                }
            }

            if (!foundMagicNumber)
            {
                Console.WriteLine("no");
            }
        }

        static bool IsMagicNumber(int num)
        {
            int sum = 0;
            string numStr = num.ToString();

            foreach (char digitChar in numStr)
            {
                int digit = digitChar - '0';

                if (!IsPrimeDigit(digit))
                {
                    return false;
                }

                sum += digit;
            }

            return sum % 2 == 0;
        }

        static bool IsPrimeDigit(int digit)
        {
            return digit == 2 || digit == 3 || digit == 5 || digit == 7;
        }
    }
    
}
