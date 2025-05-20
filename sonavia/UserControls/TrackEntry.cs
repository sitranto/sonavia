using sonavia.Models;

namespace sonavia.UserControls
{
    public partial class TrackEntry : UserControl
    {
        private Track track;
        public bool isThisTrackPlaying = false;

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
            // TODO костыль
            foreach (var entry in Parent.Controls)
            {
                if (entry is TrackEntry entry1)
                {
                    if (entry1.isThisTrackPlaying == true)
                    {
                        if (entry1 == this)
                        {
                            continue;
                        }
                        entry1.pictureBox1.Image = Properties.Resources.icon__player_button_main_gray;
                        entry1.isThisTrackPlaying = false;
                    }
                }
            }
            if (isThisTrackPlaying)
            {
                track.Pause();
                pictureBox1.Image = Properties.Resources.icon__player_button_main_gray;
                isThisTrackPlaying = false;
            }
            else
            {
                track.Play();
                pictureBox1.Image = Properties.Resources.icon_player_button_pause_gray;
                isThisTrackPlaying = true;
            }
            pictureBox1.Update();
        }
    }
}
