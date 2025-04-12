namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string reversedString = "";
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversedString += command[i];
                }
                Console.WriteLine($"{command} = {reversedString}");
                               
                command = Console.ReadLine();

            }
        }
    }
}
