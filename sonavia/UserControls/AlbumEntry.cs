using sonavia.Models;

namespace sonavia.UserControls
{
    public partial class AlbumEntry : UserControl
    {
        public List<Track> tracksInAlbum = new List<Track>();

        public AlbumEntry(string name, string artist)
        {
            InitializeComponent();
            guna2PictureBoxAlbumCover.SizeMode = PictureBoxSizeMode.StretchImage;
            labelName.Text = name;
            labelArtist.Text = artist;
        }
    }
}
