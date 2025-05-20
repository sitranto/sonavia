namespace sonavia.Forms
{
    public partial class WarningForm : Form
    {
        public string? selectedPath;

        public WarningForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
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
