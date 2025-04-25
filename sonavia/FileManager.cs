using sonavia.Forms;
using sonavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public string?[]? GetAllTracks()
        {
            var files = Directory.GetFiles(configuration.First(), "*.mp3");
            IEnumerable<Track> tracks = new List<Track>();

            if (files != null)
            {
                foreach (var file in files)
                {

                }
            }

            return Directory.GetFiles(configuration.First(), "*.mp3");
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
            var data = new byte[128];
            string name = "";
            string artist = "";
            string album = "";

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            stream.Seek(-128, SeekOrigin.End);
            stream.Read(data, 0, 128);
            stream.Close();

            for (int i = 3; i < 33; i++)
            {
                if (data[i] != 0)
                    name += Convert.ToChar(data[i]);
            }
            for (int i = 33; i < 63; i++)
            {
                if (data[i] != 0)
                    artist += Convert.ToChar(data[i]);
            }
            for (int i = 63; i < 93; i++)
            {
                if (data[i] != 0)
                    album += Convert.ToChar(data[i]);
            }

            return new Track(name, artist, album, 1);
        }
    }
}
