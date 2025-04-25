using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sonavia;

namespace sonavia.Models
{
    public class Track
    {
        public string name;
        public string artists;
        public string album;
        public string durationInSeconds;

        public Track(string name, string[] artists, string album, string durationInSeconds)
        {
            this.name = name;
            this.artists = Utils.ConvertStringArrayToOneString(artists);
            this.album = album;
            this.durationInSeconds = durationInSeconds == null ? "-" : durationInSeconds;
        }
    }
}
