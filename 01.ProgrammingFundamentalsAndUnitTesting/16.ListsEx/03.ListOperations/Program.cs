namespace _03.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];


                switch (command)
                {
                    case "Add":
                        int numToAdd = int.Parse(cmdArg[1]);
                        numbers.Add(numToAdd);
                        break; 

                    case "Insert":
                        int numToInsert = int.Parse(cmdArg[1]);
                        int position = int.Parse(cmdArg[2]);
                        if (position < 0 || position > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                        numbers.Insert(position, numToInsert);

                        }
                        break; 

                    case "Remove":
                        int indexToRemoveAt = int.Parse(cmdArg[1]);
                        if (indexToRemoveAt < 0 || indexToRemoveAt > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                        numbers.RemoveAt(indexToRemoveAt);
                        }
                        break; 
                    case "Shift":

                        string positionToShift = cmdArg[1];
                        int numToShift = int.Parse(cmdArg[2]);
                        if (positionToShift == "left")
                        {
                            for (int i = 1; i <= numToShift; i++)
                            {
                                int firstNumber = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstNumber);
                            }

                        }
                        else if (positionToShift == "right")
                        {
                        //int numToShiftRight = int.Parse(cmdArg[2]);

                            for (int i = 1; i <= numToShift; i++)
                            {
                                int lastNUmber = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, lastNUmber);
                            }

                        }
                        break;                     
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
