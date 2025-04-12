using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace _03.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string[] input = Console.ReadLine()
                                   .Split(' ');
                                   

                for (int i = 0; i < input.Length; i++)
                {
                string element = input[i];
               
                    try
                    {
                        int currentNum = int.Parse(input[i]);
                        numbers.Add(currentNum);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"The element '{element}' is in wrong format!");               
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"The element '{element}' is out of range!");                
                    }
                    finally
                    {
                        Console.WriteLine($"Element '{element}' processed - current sum: {numbers.Sum()}");

                    }
                    
                }
                        Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");
        }
    }
}
