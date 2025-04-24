using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonavia
{
    internal class FileManager
    {
        private static readonly string configurationPath = "config.ini";
        public IEnumerable<string> configuration;

        public FileManager()
        {
            CreateCongigurationIfDoesntExists();
            configuration = File.ReadAllLines(configurationPath);
        }

        /// <summary>
        /// Возвращает все треки mp3 формата, содержащиеся по адресу библиотеки из конфигурационного файла.
        /// </summary>
        /// <returns>Массив строк абсолютных путей всех треков</returns>
        public string?[]? GetAllTracks()
        {
            return Directory.GetFiles(configuration.First(), "*.mp3");
        }

        /// <summary>
        /// Создает конфигурационный файл в случае его отсутствия.
        /// </summary>
        private static void CreateCongigurationIfDoesntExists()
        {
            if (!File.Exists(configurationPath))
            {
                File.Create(configurationPath).Close();
                SelectLibraryDirectotyPath();
            }
        }

        /// <summary>
        /// Вызывает диалоговое окно для выбора директории для хранения библиотеки треков.
        /// </summary>
        private static void SelectLibraryDirectotyPath()
        {
            FolderBrowserDialog folderBrowserDialog = new ();
            folderBrowserDialog.ShowDialog();
            File.WriteAllText(configurationPath, folderBrowserDialog.SelectedPath);
        }
    }
}
