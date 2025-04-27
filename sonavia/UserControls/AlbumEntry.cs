using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
