namespace _09.WhileLoopOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            while (n % 2 == 0)
                n = int.Parse(Console.ReadLine());
            {
                if (n % 2 != 0)
                {

                Console.WriteLine(n);
              
                }
               
            }
        }
    }
}
