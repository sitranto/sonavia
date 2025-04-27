namespace sonavia.Models
{
    public class Artist(string name)
    {
        public string name = name;
        public List<Track> tracks = [];
        public List<Album> albums = [];
    }
}
