using NAudio.Wave;
using NAudio.CoreAudioApi;
using sonavia.UserControls;

namespace sonavia
{
    public static class TrackManager
    {
        public static List<string> playlist = [];
        public static int currentTrackIndex = 0;

        public static IWavePlayer wavePlayer = new WaveOutEvent();
        public static AudioFileReader? audioFileReader;
        public static WaveChannel32? volumeStream;
        public static MMDevice? defaultPlaybackDevice;

        public static string? currentArtist;
        public static string? currentTitle;
        public static Image? currentPicture;
        public static TimeSpan currentTotalDuration;
        public static int currentTotalSeconds;

        public static bool isLooping = false;
        public static bool isShuffle = false;

        public static System.Windows.Forms.Timer timer;
        public static CustomTrackBar trackBar;

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

                CheckForLoopShuffle();
                wavePlayer.Play();

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
            TagLib.Tag? file;
            string filePath = playlist[currentTrackIndex];

            try
            {
                file = TagLib.File.Create(filePath).Tag;
            }
            catch (Exception ex)
            {
                file = null;
                MessageBox.Show($"Error extracting metadata for artist name: {ex.Message}");
            }

            currentArtist = string.IsNullOrEmpty(file?.FirstPerformer) ? "Unknown" : file.FirstPerformer;
            currentTitle = string.IsNullOrEmpty(file?.Title) ? Path.GetFileNameWithoutExtension(filePath) : file.Title;
            currentPicture = file?.Pictures.Length > 0 ? Image.FromStream(new MemoryStream(file.Pictures[0].Data.Data)) : Properties.Resources.AlbumThumbnail;
        }

        public static void CheckForLoopShuffle()
        {
            if (isLooping)
            {
                wavePlayer.PlaybackStopped += LoopCurrentTrack;
                FetchTrackMetadata();
            }
            else if (isShuffle && playlist.Count > 1)
            {
                wavePlayer.PlaybackStopped += ShuffleNextTrack;
                FetchTrackMetadata();
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
    }
}
