namespace _04.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            RectangleArea(width, length);

        }

        static int RectangleArea(int x, int y)
        {
            int area = x * y;
            Console.WriteLine(area);
           
            return area;
        }
    }
}
