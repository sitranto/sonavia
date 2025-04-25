using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonavia.UserControls
{
    public partial class TrackEntry : UserControl
    {
        public string name;
        public string artist;
        public string album;
        public string duration;

        public TrackEntry(string name, string artist, string album, string duration)
        {
            InitializeComponent();
            this.name = name;
            this.artist = artist;
            this.album = album;
            this.duration = duration;
            SetLabels();
        }

        private void SetLabels()
        {
            labelName.Text = name;
            labelArtist.Text = artist;
            labelAlbum.Text = album;
            labelDuration.Text = duration;
        }
    }
}
