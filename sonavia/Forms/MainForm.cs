using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace sonavia.Forms
{
    public partial class MainForm : Form
    {
        private static bool _isPanelTopMouseClicked = false;
        private static Point _formLocation;
        private static bool _isPlaying = false;
        private const double _endAudioThreshold = 200;
        private bool _isSeeking = false;

        public MainForm()
        {
            FileManager.CreateCongigurationIfDoesntExists();
            InitializeComponent();
            FetchSystemVolumeLevel();
            TrackManager.timer = TrackBarTimer;
            TrackManager.trackBar = TrackBar;
        }

        private void FetchSystemVolumeLevel()
        {
            TrackManager.defaultPlaybackDevice = (new MMDeviceEnumerator()).GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            float defaultVolume = TrackManager.defaultPlaybackDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
            int trackBarValue = (int)(defaultVolume * 100);
            VolumeTrackBar.Value = trackBarValue;
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            _isPanelTopMouseClicked = true;
            _formLocation = e.Location;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isPanelTopMouseClicked)
            {
                Location = new Point(Location.X - _formLocation.X + e.X, Location.Y - _formLocation.Y + e.Y);
                Update();
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            _isPanelTopMouseClicked = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                if (TrackManager.wavePlayer.PlaybackState == PlaybackState.Stopped)
                {
                    TrackManager.PlayCurrentTrack();
                }
                else
                {
                    TrackManager.wavePlayer.Play();
                }
                ButtonPlay.Image = Properties.Resources.PauseButtonGray;
            }
            else
            {
                TrackManager.wavePlayer.Pause();
                ButtonPlay.Image = Properties.Resources.PlayButtonOrange;
            }
            _isPlaying = !_isPlaying;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new()
                {
                    Filter = "Audio Files|*.wav;*.mp3;*.ogg;*.flac;*.aac|All Files|*.*"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        if (!TrackManager.playlist.Contains(filePath))
                        {
                            TrackManager.playlist.Add(filePath);
                        }
                    }
                    UpdateLabels();
                }
            }
            catch
            {
                MessageBox.Show($"Error Occur opening new file");
            }
        }

        private void UpdateLabels()
        {
            TrackManager.FetchTrackMetadata();
            TrackNameLabel.Text = TrackManager.currentTitle;
            ArtistNameLabel.Text = TrackManager.currentArtist;
            AlbumPictureBox.Image = TrackManager.currentPicture;
            DurationLabel.Text = $"{TrackManager.currentTotalDuration.Hours:D2}:{TrackManager.currentTotalDuration.Minutes:D2}:{TrackManager.currentTotalDuration.Seconds:D2}";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            TrackManager.currentTrackIndex = (TrackManager.currentTrackIndex - 1 + TrackManager.playlist.Count) % TrackManager.playlist.Count;
            if (TrackManager.playlist.Count > 0)
            {
                TrackManager.FetchTrackMetadata();
                UpdateLabels();
                TrackManager.PlayCurrentTrack();
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            TrackManager.currentTrackIndex = (TrackManager.currentTrackIndex + 1) % TrackManager.playlist.Count;
            if (TrackManager.playlist.Count > 0)
            {
                TrackManager.FetchTrackMetadata();
                UpdateLabels();
                TrackManager.PlayCurrentTrack();
            }
        }

        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            TrackManager.isShuffle = !TrackManager.isShuffle;
            if (TrackManager.isShuffle)
            {
                ButtonShuffle.Image = Properties.Resources.ShuffleButtonOrange;
            }
            else
            {
                ButtonShuffle.Image = Properties.Resources.ShuffleButtonGray;
            }
        }

        private void ButtonRepeat_Click(object sender, EventArgs e)
        {
            TrackManager.isLooping = !TrackManager.isLooping;
            if (TrackManager.isLooping)
            {
                ButtonRepeat.Image = Properties.Resources.RepeatButtonOrange;
            }
            else
            {
                ButtonRepeat.Image = Properties.Resources.RepeatButtonGray;
            }
        }

        private void ButtonNext_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonNext.Image = Properties.Resources.ForwardButtonOrange;
        }

        private void ButtonBack_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonBack.Image = Properties.Resources.BackButtonOrange;
        }

        private void ButtonNext_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonNext.Image = Properties.Resources.ForwardButtonGray;
        }

        private void ButtonBack_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonBack.Image = Properties.Resources.BackButtonGray;
        }

        private void TrackBarTimer_Tick(object sender, EventArgs e)
        {
            TrackBarTimer.Start();
            if (TrackManager.audioFileReader != null && TrackManager.wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                int currentPosition = (int)(TrackManager.audioFileReader.CurrentTime.TotalSeconds);
                TrackBar.Value = currentPosition;
                TimeSpan remainingTime = TrackManager.audioFileReader.TotalTime - TrackManager.audioFileReader.CurrentTime;
                DurationLabel.Text = $"{remainingTime.Hours:D2}:{remainingTime.Minutes:D2}:{remainingTime.Seconds:D2}";

                if (remainingTime.TotalMilliseconds <= _endAudioThreshold)
                {
                    TrackBarTimer.Stop();
                    TrackManager.wavePlayer.Stop();
                    if (TrackManager.isLooping || TrackManager.isShuffle)
                    {
                        TrackManager.CheckForLoopShuffle();
                    }
                    else
                    {
                        UpdateLabels();
                    }
                }
            }
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isSeeking && TrackManager.wavePlayer.PlaybackState == PlaybackState.Paused)
            {
                TrackManager.wavePlayer.Play();
            }
            _isSeeking = false;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            if (TrackManager.audioFileReader != null)
            {
                if (TrackManager.wavePlayer.PlaybackState == PlaybackState.Playing || TrackManager.wavePlayer.PlaybackState == PlaybackState.Paused)
                {
                    if (TrackManager.wavePlayer.PlaybackState == PlaybackState.Playing)
                    {
                        TrackManager.wavePlayer.Pause();
                    }
                    TimeSpan newPosition = TimeSpan.FromSeconds(TrackBar.Value);
                    TrackManager.audioFileReader.CurrentTime = newPosition;
                    _isSeeking = true;
                }
            }
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            float volume = VolumeTrackBar.Value / 100f;
            if (TrackManager.defaultPlaybackDevice != null)
            {
                TrackManager.defaultPlaybackDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volume;
            }
        }
    }
}
