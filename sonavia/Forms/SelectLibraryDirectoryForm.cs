namespace sonavia.Forms
{
    public partial class SelectLibraryDirectoryForm : Form
    {
        /// <summary>
        /// Строка пути к библиотеке, возвращающаяся методом <see cref="Open">. Если путь не был выбран, то является null.
        /// </summary>
        public string? selectedPath;

        /// <summary>
        /// Диалоговая форма, предупреждающая пользователя об отсутствии выбранного пути к директории библиотеки.
        /// </summary>
        public SelectLibraryDirectoryForm()
        {
            InitializeComponent();
            OnLoad();
        }

        /// <summary>
        /// Инициализирует данные формы при запуске
        /// </summary>
        private void OnLoad()
        {
            label1.Text = "Перед началом работы sonavia требуется указать директорию (папку),\nгде будут распологаться ваши треки. \nМы рекомендуем использовать базовую директорию \"Музыка\" в Windows.";
            actionButtonOpen.FillColor = Utils.Color.orange;
        }

        /// <summary>
        /// Уничтожает процесс приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Открывает диалоговое окно выбора директории для библиотеки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
