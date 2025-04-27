namespace sonavia.Models
{
    public class Album(string name)
    {
        public string name = name;
        public List<Track> tracks = [];
        public Artist? artist;
    }
}
