using sonavia.Models;

namespace sonavia.UserControls
{
    public partial class TrackEntry : UserControl
    {
        private Track track;

        public TrackEntry(Track track)
        {
            InitializeComponent();
            this.track = track;
            SetLabels();
        }

        private void SetLabels()
        {
            labelName.Text = track.name;
            labelArtist.Text = track.artist?.name;
            labelAlbum.Text = track.album?.name;
            labelDuration.Text = track.durationInSeconds;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            track.Play();
        }
    }
}
