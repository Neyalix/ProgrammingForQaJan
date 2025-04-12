namespace _05.FoorLoopExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());

            for (int i = days; i > 0; i--)
            {
                if (i > 0 && i > 1)
                {

                Console.WriteLine($"{i} days before the exam");

                }
                if(i == 1)//Additional statement from me
                {
                    Console.WriteLine($"{i} day before the exam");
                }
            }
            Console.WriteLine("The exam has come");
        }
    }
}
