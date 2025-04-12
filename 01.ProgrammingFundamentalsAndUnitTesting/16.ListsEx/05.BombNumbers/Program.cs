namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();
            List<int> detonationAndPower = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();


            //detonation = 4
            //power = 2
            foreach (int item in nums)
            //{1 2 2 4 2 2 2 9}
            {
                int detonationNumber = detonationAndPower[0];//4
                if (item == detonationNumber)
                {
                    for (int j = 0; j < nums.Count; j++)
                    {

                        int powerOfDetonation = detonationAndPower[1]; //2
                        for (int i = powerOfDetonation; i > 0; i--)
                        {
                            int index = nums.IndexOf(item);
                            nums.RemoveAt(index - 1);
                            for (int x = powerOfDetonation; x > 0; x--)
                            {
                                int indexAgain = nums.IndexOf(item);
                                nums.RemoveAt(indexAgain + 1);
                            }
                        }

                    }
                }
            }
        }
    }
}
