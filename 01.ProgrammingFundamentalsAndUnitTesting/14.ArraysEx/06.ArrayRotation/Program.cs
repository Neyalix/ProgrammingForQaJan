namespace _06.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToArray();

            int rotation = int.Parse(Console.ReadLine());

            rotation = rotation % nums.Length;
            //Console.WriteLine(rotation);

            while (rotation > 0)
            {
                int numAtPosZero = nums[0];
                int[] tempNums = new int[nums.Length];
                for (int i = 1; i < nums.Length; i++)
                {
                    int currNum = nums[i];
                    tempNums[i - 1] = currNum;
                   
                }
                tempNums[nums.Length - 1] = numAtPosZero;
                nums = tempNums;
                rotation--;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
