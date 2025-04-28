using NAudio.Wave;

namespace sonavia
{
    public static class SoundManager
    {
        private static WaveOutEvent? outputDevice;
        private static AudioFileReader? audioFile;

        public static void Play(string trackPath)
        {
            if (outputDevice == null)
            {
                outputDevice = new();
                outputDevice.PlaybackStopped += PlaybackStopped;
            }

            if (audioFile == null)
            {
                audioFile = new(@trackPath);
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }

        private static void Stop()
        {
            outputDevice?.Stop();
        }

        private static void PlaybackStopped(object? sender, StoppedEventArgs args)
        {
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
        }
    }
}
