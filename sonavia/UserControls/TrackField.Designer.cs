namespace sonavia.UserControls
{
    partial class TrackField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTrackName = new Label();
            LabelArtistName = new Label();
            LabelDuration = new Label();
            ButtonPlay = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ButtonPlay).BeginInit();
            SuspendLayout();
            // 
            // LabelTrackName
            // 
            LabelTrackName.AutoEllipsis = true;
            LabelTrackName.Location = new Point(38, 14);
            LabelTrackName.Name = "LabelTrackName";
            LabelTrackName.Size = new Size(236, 21);
            LabelTrackName.TabIndex = 0;
            LabelTrackName.Text = "Track Name";
            // 
            // LabelArtistName
            // 
            LabelArtistName.AutoEllipsis = true;
            LabelArtistName.Location = new Point(280, 14);
            LabelArtistName.Name = "LabelArtistName";
            LabelArtistName.Size = new Size(150, 21);
            LabelArtistName.TabIndex = 1;
            LabelArtistName.Text = "Artist Name";
            // 
            // LabelDuration
            // 
            LabelDuration.Location = new Point(436, 14);
            LabelDuration.Name = "LabelDuration";
            LabelDuration.Size = new Size(82, 21);
            LabelDuration.TabIndex = 2;
            LabelDuration.Text = "--:--:--";
            // 
            // ButtonPlay
            // 
            ButtonPlay.Image = Properties.Resources.PlayButtonOrange;
            ButtonPlay.Location = new Point(12, 15);
            ButtonPlay.Name = "ButtonPlay";
            ButtonPlay.Size = new Size(20, 20);
            ButtonPlay.SizeMode = PictureBoxSizeMode.Zoom;
            ButtonPlay.TabIndex = 3;
            ButtonPlay.TabStop = false;
            ButtonPlay.Click += ButtonPlay_Click;
            // 
            // TrackField
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 36, 36);
            Controls.Add(ButtonPlay);
            Controls.Add(LabelDuration);
            Controls.Add(LabelArtistName);
            Controls.Add(LabelTrackName);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "TrackField";
            Size = new Size(529, 50);
            ((System.ComponentModel.ISupportInitialize)ButtonPlay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTrackName;
        private Label LabelArtistName;
        private Label LabelDuration;
        private PictureBox ButtonPlay;
    }
}
