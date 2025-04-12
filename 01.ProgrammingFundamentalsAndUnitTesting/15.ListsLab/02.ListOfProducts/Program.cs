namespace _02.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string product = Console.ReadLine();

                listOfProducts.Add(product);
            }

            listOfProducts.Sort();

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{listOfProducts[i]}");
            }
        }
    }
}
