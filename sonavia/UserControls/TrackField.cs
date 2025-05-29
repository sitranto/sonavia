namespace sonavia.UserControls
{
    public partial class TrackField : UserControl
    {
        public string path;
        public event EventHandler PlayClick;
        public event EventHandler CheckBoxCheck;

        public TrackField(string trackName, string artistName, string duration, string path)
        {
            InitializeComponent();
            LabelTrackName.Text = trackName;
            LabelArtistName.Text = artistName;
            LabelDuration.Text = duration;
            this.path = path;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (TrackManager.playlist[TrackManager.currentTrackIndex] != path)
            {
                PlayClick.Invoke(this, new EventArgs());
                TrackManager.wavePlayer.Stop();
                TrackManager.currentTrackIndex = TrackManager.playlist.IndexOf(path);
            }

            PlayClick.Invoke(this, new EventArgs());
        }

        private void TrackField_MouseEnter(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#706767");
        }

        private void TrackField_MouseLeave(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#272424");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheck.Invoke(this, new EventArgs());
        }
    }
}
