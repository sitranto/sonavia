using sonavia.Forms;

namespace sonavia
{
    internal static class FileManager
    {
        private static readonly string configurationPath = "config.ini";

        public static void CreateCongigurationIfDoesntExists()
        {
            if (!File.Exists(configurationPath))
            {
                WarningForm selectLibraryDirectoryForm = new();

                if (selectLibraryDirectoryForm.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                File.Create(configurationPath).Dispose();
                File.WriteAllText(configurationPath, selectLibraryDirectoryForm.selectedPath);
                Directory.CreateDirectory($"{GetMainPath()}\\.sonaviaPlaylists");
            }
        }

        public static List<string> GetAllTracks()
        {
            return [.. Directory.GetFiles(GetMainPath(), "*.mp3")];
        }

        public static List<string> GetAllPlaylists()
        {
            return [.. Directory.GetFiles($"{GetMainPath()}\\.sonaviaPlaylists", "*.m3u")];
        }

        public static List<string> ReadM3U(string path)
        {
            List<string> result = [];
            var reader = new StreamReader(path);
            while (true)
            {
                var line = reader.ReadLine();
                if (line == null)
                {
                    return result;
                }
                result.Add(line);
            }
        }

        public static void WriteM3U(List<string> playlist, string playlistName)
        {
            var writer = new StreamWriter($"{GetMainPath()}\\.sonaviaPlaylists\\${playlistName}.m3u");
            foreach (var item in playlist)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }

        private static string GetMainPath()
        {
            return File.ReadAllLines(configurationPath).First();
        }
    }
}
