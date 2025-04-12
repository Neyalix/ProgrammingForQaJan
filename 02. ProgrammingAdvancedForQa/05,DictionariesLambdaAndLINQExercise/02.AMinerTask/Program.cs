namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerResourse = new();

            string resourse = Console.ReadLine();

            while (resourse != "stop")
            {

                int quantity = int.Parse(Console.ReadLine());


                if (!minerResourse.ContainsKey(resourse))
                {
                    minerResourse.Add(resourse, 0);
                }

                minerResourse[resourse] += quantity;
                resourse = Console.ReadLine();
            }

            foreach (var kvp in minerResourse)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
