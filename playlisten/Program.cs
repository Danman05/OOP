using System;

namespace playlisten
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist(); // Creates playlist object

            // Adds tracks to playlist
            playlist.AddTrack("Lemon Tree");
            playlist.AddTrack("Country Roads");

            // Adds the track to first place in the linked list
            playlist.AddTrackTop("Sweet dreams (Are Made Of This)");

            // foreach loop through the linked list and write out each item in list
            foreach (Track p in playlist.playlist)
            {
                Console.WriteLine(p.TrackName);
            }
            Console.ReadLine();
        }
    }
}
