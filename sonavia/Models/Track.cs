using NAudio.Wave;

namespace sonavia.Models
{
    public class Track(string name, string trackPath)
    {
        public string name = name;
        public Artist? artist;
        public Album? album;
        public string durationInSeconds = "-";
        private string trackPath = trackPath;

        public void Play()
        {
            SoundManager.Play(trackPath);
        }
    }
}
