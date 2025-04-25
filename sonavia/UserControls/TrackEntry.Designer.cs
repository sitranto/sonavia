namespace sonavia.UserControls
{
    partial class TrackEntry
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelArtist = new Label();
            labelAlbum = new Label();
            labelDuration = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoEllipsis = true;
            labelName.Cursor = Cursors.Hand;
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(59, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(117, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelArtist
            // 
            labelArtist.AutoEllipsis = true;
            labelArtist.Cursor = Cursors.Hand;
            labelArtist.ForeColor = SystemColors.Control;
            labelArtist.Location = new Point(190, 14);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(129, 15);
            labelArtist.TabIndex = 1;
            labelArtist.Text = "Исполнитель";
            labelArtist.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAlbum
            // 
            labelAlbum.AutoEllipsis = true;
            labelAlbum.ForeColor = SystemColors.Control;
            labelAlbum.Location = new Point(338, 14);
            labelAlbum.Name = "labelAlbum";
            labelAlbum.Size = new Size(119, 15);
            labelAlbum.TabIndex = 2;
            labelAlbum.Text = "Альбом";
            labelAlbum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDuration
            // 
            labelDuration.AutoEllipsis = true;
            labelDuration.Cursor = Cursors.Hand;
            labelDuration.ForeColor = SystemColors.Control;
            labelDuration.Location = new Point(477, 14);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(84, 15);
            labelDuration.TabIndex = 3;
            labelDuration.Text = "Длительность";
            labelDuration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon__player_button_main_gray;
            pictureBox1.Location = new Point(26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TrackEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Controls.Add(labelDuration);
            Controls.Add(labelAlbum);
            Controls.Add(labelArtist);
            Controls.Add(labelName);
            Name = "TrackEntry";
            Size = new Size(599, 40);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private Label labelArtist;
        private Label labelAlbum;
        private Label labelDuration;
        private PictureBox pictureBox1;
    }
}
