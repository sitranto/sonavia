using System.Security.Cryptography.X509Certificates;
using sonavia.Forms;

namespace sonavia
{
    /// <summary>
    /// Менеджер управления файлами директории библиотеки и файла конфигурации приложения.
    /// </summary>
    internal static class FileManager
    {
        private static readonly string configurationPath = "config.ini";

        /// <summary>
        /// Возвращает все треки mp3 формата, содержащиеся по адресу библиотеки из конфигурационного файла.
        /// </summary>
        /// <returns>Массив строк абсолютных путей всех треков или пустой массив, в случае отсутствия файлов в директории.</returns>
        public static string[] GetAllTracks()
        {
            return Directory.GetFiles(File.ReadAllLines(configurationPath).First(), "*.mp3");
        }

        public static TagLib.Tag GetTrackMetaData(string path)
        {
            return TagLib.File.Create(path).Tag;
        }

        /// <summary>
        /// Создает диалоговое окно <see cref="SelectLibraryDirectoryForm"/> для записи данных в конфигурационный файл, в случае его отсутствия.
        /// </summary>
        public static void CreateCongigurationIfDoesntExists()
        {
            if (!File.Exists(configurationPath))
            {
                SelectLibraryDirectoryForm selectLibraryDirectoryForm = new();

                if (selectLibraryDirectoryForm.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                File.Create(configurationPath).Dispose();
                File.WriteAllText(configurationPath, selectLibraryDirectoryForm.selectedPath);
            }
        }
    }
}
