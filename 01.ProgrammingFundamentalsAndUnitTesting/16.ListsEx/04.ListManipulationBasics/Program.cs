namespace _04.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();


            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];

               
               
                if (command == "Add")
                {
                    int numToAdd = int.Parse(cmdArg[1]);
                    nums.Add(numToAdd);
                }
                else if (command == "Remove")
                {
                    int numToRemove = int.Parse(cmdArg[1]);
                    nums.Remove(numToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(cmdArg[1]);
                   
                    nums.RemoveAt(index);

                }
                else if (command == "Insert")
                {
                int position = int.Parse(cmdArg[2]);
                int numToInsert = int.Parse(cmdArg[1]);
                    nums.Insert(position, numToInsert);
                }
            input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
