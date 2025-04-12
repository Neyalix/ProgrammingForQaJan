namespace _00.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice diceD6 = new Dice(6);
            //diceD6.Sides = 6;

            Console.WriteLine(diceD6.Roll());
        }
    }

         

       public class Dice
    {

        public Dice(int sides)
        {
            Sides = 6;
        }

        public int Sides { get; set; }

        public int Roll()
        {
            Random random = new Random();

            return random.Next(1, Sides + 1);
        }
    }
}
