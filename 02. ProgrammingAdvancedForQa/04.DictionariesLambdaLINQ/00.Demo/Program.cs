namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>();

            fruits["banana"] = 2.20;
            fruits["apple"] = 1.90;
            fruits["strawberry"] = 4.90;

            fruits.Add("pear", 1.45);

            fruits.Remove("orange");
            fruits.Add("mango", 4.950);

            //foreach (var kvp in fruits)
            //{

            //Console.WriteLine(  $"Fruit: {kvp.Key} - Price: {kvp.Value:f2}");
            //}

            Dictionary<string, string> phoneBook = new()
            {
                { "Mihail Mihaylov", "+359 889 651 328"}
            };
            phoneBook.Add("Philip Mihaylov", "+359 886 020 017");
            phoneBook.Add("Anzhela Dragieva", "+359 889 608 586");

            if (phoneBook.ContainsKey("Mihail Mihaylov"))
            {
                Console.WriteLine("Key is already added");
            }
            else
            {
                phoneBook.Add("Pesho Peshov", "+359 888 888 888");
            }
        }
    }
}
