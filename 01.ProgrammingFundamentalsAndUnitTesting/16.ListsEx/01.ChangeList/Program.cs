namespace _01.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];
                if (command == "Delete")
                {
                int n = int.Parse(cmdArg[1]);

                    //Nother way to search for the number to remove!!!
                    //while (num.Contains(n))
                    //{
                    //    num.Remove(n);
                    //}
                    num.RemoveAll(x => x == n);
                }
                else if (command == "Insert")
                {
                    int numToInsert = int.Parse(cmdArg[2]);
                    int posToInsert = int.Parse(cmdArg[1]);
                    num.Insert(numToInsert, posToInsert);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
