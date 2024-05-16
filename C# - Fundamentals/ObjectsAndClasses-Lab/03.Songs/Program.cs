namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] songsInfo = Console.ReadLine().Split("_");
                Song song = new Song();
                song.TypeList = songsInfo[0];
                song.Name = songsInfo[1];
                song.Time = songsInfo[2];


                playlist.Add(song);
            }

            string type = Console.ReadLine();
            if (type == "all")
            {
                foreach (var song in playlist)
                {
                    Console.WriteLine(song.Name);
                }
            }
            foreach (var song in playlist)
            {
                if (song.TypeList == type)
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
