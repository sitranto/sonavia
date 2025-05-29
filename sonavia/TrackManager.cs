using NAudio.Wave;
using NAudio.CoreAudioApi;
using sonavia.UserControls;
using System.Runtime.CompilerServices;

namespace sonavia
{
    public static class TrackManager
    {
        public static List<string> playlist = FileManager.GetAllTracks();
        public static List<string> queue = [];
        public static int currentTrackIndex = 0;

        public static IWavePlayer wavePlayer = new WaveOutEvent();
        public static AudioFileReader? audioFileReader;
        public static WaveChannel32? volumeStream;
        public static MMDevice? defaultPlaybackDevice;

        public static TagLib.Tag? currentMetaData;
        public static TimeSpan currentTotalDuration;
        public static int currentTotalSeconds;

        public static bool isPlaying = false;
        public static bool isLooping = false;
        public static bool isShuffle = false;

        public static System.Windows.Forms.Timer timer;
        public static CustomTrackBar trackBar;

        public static event EventHandler TrackPlayed;

        public static void PlayCurrentTrack()
        {
            if (playlist != null && playlist.Count > 0 && currentTrackIndex < playlist.Count)
            {

                if (audioFileReader != null)
                {
                    wavePlayer.Stop();
                    wavePlayer.Dispose();
                    audioFileReader.Dispose();
                    StopTimer();
                }

                audioFileReader = new AudioFileReader(playlist[currentTrackIndex]);
                volumeStream = new WaveChannel32(audioFileReader);
                wavePlayer = new WaveOut();
                wavePlayer.Init(audioFileReader);

                FetchTrackMetadata();
                CheckForLoopShuffle();
                wavePlayer.Play();
                isPlaying = true;
                TrackPlayed.Invoke(null, EventArgs.Empty);

                MMDeviceEnumerator enumerator = new();
                defaultPlaybackDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                currentTotalSeconds = (int)audioFileReader.TotalTime.TotalSeconds;
                trackBar.Maximum = currentTotalSeconds;
                currentTotalDuration = audioFileReader.TotalTime;

                StartTimer();
            }
        }
       
        public static void FetchTrackMetadata()
        {
            try
            {
                currentMetaData = TagLib.File.Create(playlist[currentTrackIndex]).Tag;
            }
            catch
            {
                currentMetaData = null;
            }
        }

        public static void FetchTrackMetadata(int index)
        {
            try
            {
                currentMetaData = TagLib.File.Create(playlist[index]).Tag;
            }
            catch
            {
                currentMetaData = null;
            }

            audioFileReader = new AudioFileReader(playlist[index]);
            currentTotalDuration = audioFileReader.TotalTime;
        }

        public static void CheckForLoopShuffle()
        {
            if (isLooping)
            {
                wavePlayer.PlaybackStopped += LoopCurrentTrack;
            }
            else if (isShuffle && playlist.Count > 1)
            {
                wavePlayer.PlaybackStopped += ShuffleNextTrack;
            }
        }
        
        public static void Next()
        {
            if (isLooping)
            {
                LoopCurrentTrack(null, null);
            }
            else if (isShuffle && playlist.Count > 1)
            {
                ShuffleNextTrack(null, null);
            }
            else
            {
                currentTrackIndex = (currentTrackIndex + 1) % playlist.Count;
                PlayCurrentTrack();
            }
        }

        private static void ShuffleNextTrack(object? sender, StoppedEventArgs e)
        {
            if (isShuffle)
            {
                int nextIndex;
                do
                {
                    nextIndex = new Random().Next(0, playlist.Count);
                } while (nextIndex == currentTrackIndex);

                currentTrackIndex = nextIndex;
            }
            else
            {
                currentTrackIndex = (currentTrackIndex + 1) % playlist.Count;
            }

            PlayCurrentTrack();
        }

        private static void LoopCurrentTrack(object? sender, StoppedEventArgs e)
        {
            if (isLooping)
            {
                PlayCurrentTrack();
            }
        }

        private static void StartTimer()
        {
            timer.Enabled = true;
            timer.Start();
        }

        private static void StopTimer()
        {
            timer.Stop();
        }

        public static string GetCurrentTitle(int index)
        {
            return string.IsNullOrEmpty(currentMetaData?.Title) ? Path.GetFileNameWithoutExtension(playlist[index]) : currentMetaData.Title;
        }

        public static string GetCurrentArtist()
        {
            return string.IsNullOrEmpty(currentMetaData?.FirstPerformer) ? "Unknown" : currentMetaData.FirstPerformer;
        }

        public static Image GetCurrentAlbumCover()
        {
            try
            {
                if (currentMetaData?.Pictures.Length > 0)
                {
                    return Image.FromStream(new MemoryStream(currentMetaData.Pictures[0].Data.Data));
                }
            }
            catch 
            {
                Console.WriteLine("Error");
            }
            return Properties.Resources.AlbumThumbnail;
        }

        public static string GetCurrentAlbumName()
        {
            return string.IsNullOrEmpty(currentMetaData?.Album) ? "Unknown" : currentMetaData.Album;
        }

        public static string GetCurrentGenre()
        {
            return string.IsNullOrEmpty(currentMetaData?.Genres.FirstOrDefault()) ? "Unknown" : currentMetaData.Genres.First();
        }

        public static string GetCurrentYear()
        {
            return string.IsNullOrEmpty(currentMetaData?.Year.ToString()) ? "Unknown" : currentMetaData.Year.ToString(); 
        }
    }
}
