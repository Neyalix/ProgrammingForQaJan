namespace _02.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfCommand = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 1; i <= numOfCommand; i++)
            {

                string command = Console.ReadLine();
                string[] cmdArg = command.Split(" ");
                string name = cmdArg[0];

                if (cmdArg.Length == 3)
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else if (cmdArg.Length == 4)
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    

                }

            }
                foreach (string allGuests in names)
                {
                    Console.WriteLine(allGuests);
                }
            
            
        }
    }
}
