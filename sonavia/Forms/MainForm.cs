using sonavia.UserControls;

namespace sonavia.Forms
{
    public partial class MainForm : Form
    {
        private static bool isPanelTopMouseClicked = false;
        private static Point formLocation;

        public MainForm()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            FileManager.CreateCongigurationIfDoesntExists();
            TrackManager.GetMusicData();
            ActivateStartButtons();
            SetButtonsCollections();
            PaintLibrary();
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            isPanelTopMouseClicked = true;
            formLocation = e.Location;
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isPanelTopMouseClicked = false;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPanelTopMouseClicked)
            {
                Location = new Point(Location.X - formLocation.X + e.X, Location.Y - formLocation.Y + e.Y);
                Update();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivateStartButtons()
        {
            actionButtonLibrary.FillColor = Utils.Color.orange;
            actionButtonQueue.FillColor = Utils.Color.orange;
            labelTitle.Text = "Библиотека:";
        }

        private void SetButtonsCollections()
        {
            foreach (ActionButton actionButton in splitContainerMain.Panel1.Controls.OfType<ActionButton>())
            {
                actionButton.SetPanelCollection([panelLibrary, panelAlbums, panelArtists]);
            }
            foreach (ActionButton actionButton in splitContainerыSupportive.Panel1.Controls.OfType<ActionButton>())
            {
                actionButton.SetPanelCollection([panelQueue, panelAbout]);
            }
        }

        private void PaintLibrary()
        {
            var y = 67;

            foreach (var track in TrackManager.tracks)
            {
                var trackEntry = new TrackEntry(track);
                trackEntry.Location = new Point(12, y);
                y += trackEntry.Height;


                panelLibrary.Controls.Add(trackEntry);
            }

            y = 5;

            foreach (var album in TrackManager.albums)
            {
                var albumEntry = new AlbumEntry(album.name, album.artist!.name);
                albumEntry.Location = new Point(y, 15);
                y += albumEntry.Width;

                panelAlbums.Controls.Add(albumEntry);
            }

            y = 5;

            foreach(var artist in TrackManager.artists)
            {
                var artistEntry = new ArtistEntry(artist.name);
                artistEntry.Location = new Point(y, 15);
                y += artistEntry.Width;

                panelArtists.Controls.Add(artistEntry);
            }
        }

    }
}
