namespace _13.WhileLoopNumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Inc")
                {
                    n++;
                }
                else if (command == "Dec")
                {
                    n--;
                }
                command = Console.ReadLine();
                
                
            }
                Console.WriteLine(n);
        }
    }
}
