
namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine()
                                        .Split();

                string command = input[0];
                string user = input[1];

                

                if (command == "register")
                {
                    string licensePlate = input[2];

                    if (parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    if(!parking.ContainsKey(user))
                    {
                        parking.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        parking.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }

            }
                foreach (var kvp in parking)
                {
                    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
                }
        }
    }
}
