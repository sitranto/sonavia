using sonavia.Forms;
using sonavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sonavia
{
    internal class FileManager
    {
        private static readonly string configurationPath = "config.ini";
        /// <summary>
        /// Список данных конфигурационного файла.
        /// </summary>
        public IEnumerable<string> configuration;

        /// <summary>
        /// Менеджер управления файлами директории библиотеки и файла конфигурации приложения.
        /// </summary>
        public FileManager()
        {
            CreateCongigurationIfDoesntExists();
            configuration = File.ReadAllLines(configurationPath);
        }

        /// <summary>
        /// Возвращает все треки mp3 формата, содержащиеся по адресу библиотеки из конфигурационного файла.
        /// </summary>
        /// <returns>Массив строк абсолютных путей всех треков или пустой массив, в случае отсутствия файлов в директории.</returns>
        public IEnumerable<Track> GetAllTracks()
        {
            var files = Directory.GetFiles(configuration.First(), "*.mp3");
            List<Track> tracks = new List<Track>();

            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    tracks.Add(GetTrackData(file));
                }
            }

            return tracks;
        }

        /// <summary>
        /// Создает диалоговое окно <see cref="SelectLibraryDirectoryForm"/> для записи данных в конфигурационный файл, в случае его отсутствия.
        /// </summary>
        private static void CreateCongigurationIfDoesntExists()
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

        private Track GetTrackData(string path)
        {
            var file = TagLib.File.Create(path);

            return new Track(file.Tag.Title, file.Tag.Performers, file.Tag.Album, file.Tag.Length);
        }
    }
}
