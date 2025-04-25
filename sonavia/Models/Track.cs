using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonavia.Models
{
    internal class Track(string name, string artist, string album, int durationInSeconds)
    {
        public string name = name;
        public string artist = artist;
        public string album = album;
        public int durationInSeconds = durationInSeconds;
    }
}
