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
            labelArtist.Text = track.artists;
            labelAlbum.Text = track.album;
            labelDuration.Text = track.durationInSeconds.ToString();
        }
    }
}
