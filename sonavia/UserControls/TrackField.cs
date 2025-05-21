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
    public partial class TrackField : UserControl
    {
        private string _path;

        public TrackField(string trackName, string artistName, string duration, string path)
        {
            InitializeComponent();
            LabelTrackName.Text = trackName;
            LabelArtistName.Text = artistName;
            LabelDuration.Text = duration;
            _path = path;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            TrackManager.wavePlayer.Stop();
            TrackManager.currentTrackIndex = TrackManager.playlist.IndexOf(_path);
            TrackManager.PlayCurrentTrack();
        }
    }
}
