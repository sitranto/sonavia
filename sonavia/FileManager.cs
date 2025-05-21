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
            }
        }

        public static List<string> GetAllTracks()
        {
            return [.. Directory.GetFiles(File.ReadAllLines(configurationPath).First(), "*.mp3")];
        }
    }
}
