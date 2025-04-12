
using System.Runtime.ExceptionServices;

namespace _01.Songs
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Songs> song = new List<Songs>();

            for (int i = 0; i < n; i++)
            {
                string[] songData = Console.ReadLine()
                                           .Split('_');

                Songs currentSong = new Songs();

                currentSong.TypeList = songData[0];

                currentSong.Name = songData[1];

                currentSong.Time = songData[2];

                song.Add(currentSong);

            }

            string typeName = Console.ReadLine();

            if (typeName == "all")
            {
                foreach (var item in song)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in song.Where(s => s.TypeList == typeName))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    public class Songs
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

}
