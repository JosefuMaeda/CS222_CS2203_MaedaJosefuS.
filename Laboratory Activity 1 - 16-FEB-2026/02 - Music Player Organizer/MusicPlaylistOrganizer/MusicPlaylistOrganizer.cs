using System;

namespace MusicPlaylistOrganizer
{
    class Song
    {
        public string title;
        public string artist;
        public double duration;

        public Song()
        {
            title = "Unknown";
            artist = "Unknown";
            duration = 0;
        }

        public Song(string title, string artist, double duration) : this(title, artist)
        {
            this.duration = duration;
        }

        public Song(string title, string artist) : this()
        {
            this.title = title;
            this.artist = artist;
        }

        public void DisplaySong()
        {
            Console.WriteLine($"{title,-15} {artist,-15} {duration:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Songs to add: ");
            int numSongs = int.Parse(Console.ReadLine());
            
            Song[] playlist = new Song[numSongs];
            
            for (int i = 0; i < numSongs; i++)
            {
                Console.WriteLine($"\nSong #{i + 1}");
                
                Console.Write("Title: ");
                string title = Console.ReadLine();
                
                Console.Write("Artist: ");
                string artist = Console.ReadLine();
                
                Console.Write("Duration (minutes): ");
                double duration = double.Parse(Console.ReadLine());
                
                playlist[i] = new Song(title, artist, duration);
            }
            
            Console.WriteLine("\n=== || MY PLAYLIST || ===");
            Console.WriteLine($"{"Title",-15} {"Artist",-15} {"Time",-10}");
            Console.WriteLine("----------------------------------------------");
            
            double totalDuration = 0;
            
            foreach (Song song in playlist)
            {
                song.DisplaySong();
                totalDuration += song.duration;
            }
            
            double averageDuration = totalDuration / numSongs;
            
            Console.WriteLine($"\nTotal Duration: {totalDuration:F2} mins");
            Console.WriteLine($"Average Duration: {averageDuration:F2} mins");
        }
    }
}