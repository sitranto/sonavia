using System.Data;
using sonavia.UserControls;

namespace sonavia.Forms
{
    public partial class AddPlaylistForm : Form
    {
        private List<string> playlist = [];

        public AddPlaylistForm()
        {
            InitializeComponent();
            Point position = new(0, 0);
            foreach (var track in TrackManager.playlist.Select((value, i) => new { i, value }))
            {
                TrackManager.FetchTrackMetadata(track.i);
                TrackField field = new(
                    TrackManager.GetCurrentTitle(track.i),
                    TrackManager.GetCurrentArtist(),
                    "",
                    track.value
                    )
                {
                    Parent = PanelTrackList,
                    Location = position,
                };
                field.Controls.Remove(field.ButtonPlay);
                field.CheckBox.Visible = true;
                field.CheckBoxCheck += CheckBoxCheck;
                PanelTrackList.Controls.Add(field);
                position.Y += field.Height;
                if (TrackManager.playlist.Count > 4)
                {
                    CustomScrollBarTrackList.Height = PanelTrackListWrapper.Height;
                    CustomScrollBarTrackList.LargeChange = PanelTrackList.Height - (TrackManager.playlist.Count - 4) * 50;
                    PanelTrackList.Height = position.Y;
                }
                else
                {
                    CustomScrollBarTrackList.Visible = false;
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBoxCheck(object? sender, EventArgs e)
        {
            var field = (TrackField)sender!;
            var checkBox = field.CheckBox;
            var track = field.path;

            if (checkBox.Checked)
            {
                playlist.Add(track);
                checkBox.Text = $"{playlist.IndexOf(track) + 1} in";
            }
            else
            {
                playlist.Remove(track);
                checkBox.Text = "";
                RewriteCheckBoxLabels();
            }
        }

        private void RewriteCheckBoxLabels()
        {
            foreach (TrackField field in PanelTrackList.Controls)
            {
                if (field.CheckBox.Checked)
                {
                    field.CheckBox.Text = $"{playlist.IndexOf(field.path) + 1} in";
                }
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (TextBoxPlaylistName.Text.Length == 0)
            {
                return;
            }
            FileManager.WriteM3U(playlist, TextBoxPlaylistName.Text);
            Close();
        }

        private void PanelTrackList_Scroll(object sender, int e)
        {
            PanelTrackList.Top = -e;
        }
    }
}
