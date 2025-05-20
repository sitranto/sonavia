using NAudio.Wave;

namespace sonavia
{
    public static class SoundManager
    {
        private static readonly WaveOutEvent outputDevice = new();
        private static AudioFileReader? currentAudioFile;

        public static void Play(string trackPath)
        {   
            if (currentAudioFile == null)
            {
                currentAudioFile = new(@trackPath);
                outputDevice.Init(currentAudioFile);
            }
            else
            {
                if (currentAudioFile.FileName != trackPath)
                {
                    Stop();
                    currentAudioFile = new(trackPath);
                    outputDevice.Init(currentAudioFile);
                }
            }

            outputDevice.Play();
        }

        public static void Pause()
        {
            outputDevice?.Pause();
        }

        public static void Stop()
        {
            outputDevice.Stop();
            currentAudioFile?.Dispose();
            currentAudioFile = null;
        }
    }
}
