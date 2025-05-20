using sonavia.UserControls;

namespace sonavia.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ButtonClose = new Button();
            PanelTop = new Panel();
            NameLabel = new Label();
            AlbumPictureBox = new PictureBox();
            TrackNameLabel = new Label();
            ArtistNameLabel = new Label();
            DurationLabel = new Label();
            ButtonPlay = new PictureBox();
            ButtonBack = new PictureBox();
            ButtonNext = new PictureBox();
            ButtonShuffle = new PictureBox();
            ButtonRepeat = new PictureBox();
            button1 = new Button();
            TrackBarTimer = new System.Windows.Forms.Timer(components);
            TrackBar = new CustomTrackBar();
            VolumeTrackBar = new CustomTrackBar();
            PanelTrack = new Panel();
            ((System.ComponentModel.ISupportInitialize)AlbumPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonShuffle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonRepeat).BeginInit();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ForeColor = SystemColors.Control;
            ButtonClose.Location = new Point(769, 0);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(32, 32);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "X";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // PanelTop
            // 
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(763, 32);
            PanelTop.TabIndex = 1;
            PanelTop.MouseDown += PanelTop_MouseDown;
            PanelTop.MouseMove += PanelTop_MouseMove;
            PanelTop.MouseUp += PanelTop_MouseUp;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 6);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(73, 21);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Sonavia";
            // 
            // AlbumPictureBox
            // 
            AlbumPictureBox.Image = Properties.Resources.AlbumThumbnail;
            AlbumPictureBox.Location = new Point(12, 343);
            AlbumPictureBox.Name = "AlbumPictureBox";
            AlbumPictureBox.Size = new Size(70, 70);
            AlbumPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AlbumPictureBox.TabIndex = 2;
            AlbumPictureBox.TabStop = false;
            // 
            // TrackNameLabel
            // 
            TrackNameLabel.AutoEllipsis = true;
            TrackNameLabel.Location = new Point(88, 343);
            TrackNameLabel.Name = "TrackNameLabel";
            TrackNameLabel.Size = new Size(151, 21);
            TrackNameLabel.TabIndex = 3;
            TrackNameLabel.Text = "Track Name";
            // 
            // ArtistNameLabel
            // 
            ArtistNameLabel.AutoEllipsis = true;
            ArtistNameLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ArtistNameLabel.Location = new Point(90, 364);
            ArtistNameLabel.Name = "ArtistNameLabel";
            ArtistNameLabel.Size = new Size(149, 16);
            ArtistNameLabel.TabIndex = 4;
            ArtistNameLabel.Text = "Artist Name";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DurationLabel.Location = new Point(556, 343);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(63, 16);
            DurationLabel.TabIndex = 7;
            DurationLabel.Text = "--:--:--";
            // 
            // ButtonPlay
            // 
            ButtonPlay.Image = Properties.Resources.PlayButtonOrange;
            ButtonPlay.Location = new Point(380, 373);
            ButtonPlay.Name = "ButtonPlay";
            ButtonPlay.Size = new Size(40, 40);
            ButtonPlay.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonPlay.TabIndex = 8;
            ButtonPlay.TabStop = false;
            ButtonPlay.Click += ButtonPlay_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.Image = Properties.Resources.BackButtonGray;
            ButtonBack.Location = new Point(344, 378);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(30, 30);
            ButtonBack.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonBack.TabIndex = 9;
            ButtonBack.TabStop = false;
            ButtonBack.Click += ButtonBack_Click;
            ButtonBack.MouseDown += ButtonBack_MouseDown;
            ButtonBack.MouseUp += ButtonBack_MouseUp;
            // 
            // ButtonNext
            // 
            ButtonNext.Image = Properties.Resources.ForwardButtonGray;
            ButtonNext.Location = new Point(426, 378);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(30, 30);
            ButtonNext.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonNext.TabIndex = 10;
            ButtonNext.TabStop = false;
            ButtonNext.Click += ButtonNext_Click;
            ButtonNext.MouseDown += ButtonNext_MouseDown;
            ButtonNext.MouseUp += ButtonNext_MouseUp;
            // 
            // ButtonShuffle
            // 
            ButtonShuffle.Image = Properties.Resources.ShuffleButtonGray;
            ButtonShuffle.Location = new Point(308, 378);
            ButtonShuffle.Name = "ButtonShuffle";
            ButtonShuffle.Size = new Size(30, 30);
            ButtonShuffle.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonShuffle.TabIndex = 11;
            ButtonShuffle.TabStop = false;
            ButtonShuffle.Click += ButtonShuffle_Click;
            // 
            // ButtonRepeat
            // 
            ButtonRepeat.Image = Properties.Resources.RepeatButtonGray;
            ButtonRepeat.Location = new Point(462, 378);
            ButtonRepeat.Name = "ButtonRepeat";
            ButtonRepeat.Size = new Size(30, 30);
            ButtonRepeat.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonRepeat.TabIndex = 12;
            ButtonRepeat.TabStop = false;
            ButtonRepeat.Click += ButtonRepeat_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(687, 38);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 13;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TrackBarTimer
            // 
            TrackBarTimer.Tick += TrackBarTimer_Tick;
            // 
            // TrackBar
            // 
            TrackBar.Location = new Point(250, 338);
            TrackBar.Maximum = 100;
            TrackBar.Name = "TrackBar";
            TrackBar.Size = new Size(300, 26);
            TrackBar.TabIndex = 15;
            TrackBar.Value = 0;
            TrackBar.Scroll += TrackBar_Scroll;
            TrackBar.MouseUp += TrackBar_MouseUp;
            // 
            // VolumeTrackBar
            // 
            VolumeTrackBar.Location = new Point(663, 338);
            VolumeTrackBar.Maximum = 100;
            VolumeTrackBar.Name = "VolumeTrackBar";
            VolumeTrackBar.Size = new Size(125, 26);
            VolumeTrackBar.TabIndex = 16;
            VolumeTrackBar.Value = 0;
            VolumeTrackBar.Scroll += VolumeTrackBar_Scroll;
            // 
            // PanelTrack
            // 
            PanelTrack.BackColor = Color.FromArgb(39, 36, 36);
            PanelTrack.Location = new Point(90, 38);
            PanelTrack.Name = "PanelTrack";
            PanelTrack.Size = new Size(529, 294);
            PanelTrack.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(800, 425);
            Controls.Add(PanelTrack);
            Controls.Add(VolumeTrackBar);
            Controls.Add(TrackBar);
            Controls.Add(button1);
            Controls.Add(ButtonRepeat);
            Controls.Add(ButtonShuffle);
            Controls.Add(ButtonNext);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonPlay);
            Controls.Add(NameLabel);
            Controls.Add(DurationLabel);
            Controls.Add(ArtistNameLabel);
            Controls.Add(TrackNameLabel);
            Controls.Add(AlbumPictureBox);
            Controls.Add(PanelTop);
            Controls.Add(ButtonClose);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)AlbumPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonShuffle).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonRepeat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Panel PanelTop;
        private PictureBox AlbumPictureBox;
        private Label TrackNameLabel;
        private Label ArtistNameLabel;
        private Label DurationLabel;
        private Label NameLabel;
        private PictureBox ButtonPlay;
        private PictureBox ButtonBack;
        private PictureBox ButtonNext;
        private PictureBox ButtonShuffle;
        private PictureBox ButtonRepeat;
        private Button button1;
        private System.Windows.Forms.Timer TrackBarTimer;
        private CustomTrackBar TrackBar;
        private CustomTrackBar VolumeTrackBar;
        private Panel PanelTrack;
    }
}