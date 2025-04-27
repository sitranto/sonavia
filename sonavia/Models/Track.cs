namespace sonavia.Models
{
    public class Track(string name)
    {
        public string name = name;
        public Artist? artist;
        public Album? album;
        public string durationInSeconds = "-";
    }
}
