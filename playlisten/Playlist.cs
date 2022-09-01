using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playlisten
{
    class Playlist
    {
        // Linked list creation
        public LinkedList<Track> playlist = new LinkedList<Track>();

        // methods
        // AddTrack adds the track to the bottom of the list
        public void AddTrack(string trackName)
        {
            Track track = new Track(trackName);
            playlist.AddLast(track);
        }
        // RemoveTrack Remove the track in the list
        public void RemoveTrack(string trackName)
        {
            Track track = new Track(trackName);
            playlist.Remove(track);
        }
        // AddTrackAtTop adds the track to first place in the list
        public void AddTrackTop(string trackName)
        {
            Track track = new Track(trackName);
            playlist.AddFirst(track);
        }
    }
}
