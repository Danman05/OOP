using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playlisten
{
    class Track
    {
        // Field variables
        private string trackName;

        // properties
        public string TrackName { get { return trackName; } }

        // Constructor
        public Track(string trackName)
        {
            this.trackName = trackName;
        }
    }
}
