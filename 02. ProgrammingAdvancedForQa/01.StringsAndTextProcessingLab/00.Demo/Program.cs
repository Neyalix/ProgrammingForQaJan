using System.Diagnostics;
using System.Text;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 200000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
