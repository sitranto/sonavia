namespace sonavia.UserControls
{
    partial class AlbumEntry
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBoxAlbumCover = new Guna.UI2.WinForms.Guna2PictureBox();
            labelName = new Label();
            labelArtist = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBoxAlbumCover).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBoxAlbumCover
            // 
            guna2PictureBoxAlbumCover.BorderRadius = 6;
            guna2PictureBoxAlbumCover.CustomizableEdges = customizableEdges1;
            guna2PictureBoxAlbumCover.Image = Properties.Resources.music_thumbnail;
            guna2PictureBoxAlbumCover.ImageRotate = 0F;
            guna2PictureBoxAlbumCover.Location = new Point(8, 3);
            guna2PictureBoxAlbumCover.Name = "guna2PictureBoxAlbumCover";
            guna2PictureBoxAlbumCover.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBoxAlbumCover.Size = new Size(135, 135);
            guna2PictureBoxAlbumCover.TabIndex = 0;
            guna2PictureBoxAlbumCover.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoEllipsis = true;
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(8, 141);
            labelName.Name = "labelName";
            labelName.Size = new Size(135, 18);
            labelName.TabIndex = 1;
            labelName.Text = "Название альбома";
            // 
            // labelArtist
            // 
            labelArtist.AutoEllipsis = true;
            labelArtist.ForeColor = SystemColors.Control;
            labelArtist.Location = new Point(8, 159);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(135, 18);
            labelArtist.TabIndex = 2;
            labelArtist.Text = "Исполнитель";
            // 
            // AlbumEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(labelArtist);
            Controls.Add(labelName);
            Controls.Add(guna2PictureBoxAlbumCover);
            Name = "AlbumEntry";
            Size = new Size(150, 187);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBoxAlbumCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxAlbumCover;
        private Label labelName;
        private Label labelArtist;
    }
}
