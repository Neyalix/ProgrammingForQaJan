namespace _01.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
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
                        int numToRemove = int.Parse(cmdArg[1]);

                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] == numToRemove)
                            {
                                nums.RemoveAt(i);
                                i--;
                            }
                        }
                        
                    }
                    else if (command == "Insert")
                    {
                        int position = int.Parse(cmdArg[2]);
                        int numToAdd = int.Parse(cmdArg[1]);
                        nums.Insert(position, numToAdd);
                    }
                input = Console.ReadLine();
            }
                        Console.WriteLine(string.Join(" ", nums));
        }
    }
}
