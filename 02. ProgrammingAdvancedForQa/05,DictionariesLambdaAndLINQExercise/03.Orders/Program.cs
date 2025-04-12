using System.Globalization;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> finalProduct = new();


            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productInput = input.Split(' ');

                string product = productInput[0];
                double productPrice = double.Parse(productInput[1]);
                double productQuantity = double.Parse(productInput[2]);

                if (!finalProduct.ContainsKey(product))
                {
                    finalProduct.Add(product, new double[2]);
                }

                finalProduct[product] [0] = productPrice;
                finalProduct[product] [1] += productQuantity;

                input = Console.ReadLine();
            }

            foreach (var kvp in finalProduct)
            {
                double kvpPrice = kvp.Value[0];
                double kvpQuantity = kvp.Value[1];

                double totalPRice = kvpPrice * kvpQuantity;

                Console.WriteLine($"{kvp.Key} -> {totalPRice:F2}");
            }
        }
    }
}
