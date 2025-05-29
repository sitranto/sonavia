namespace sonavia.Forms
{
    partial class AddPlaylistForm
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
            PanelTop = new Panel();
            ButtonClose = new Button();
            PanelTrackContainer = new Panel();
            PanelTrackListWrapper = new Panel();
            CustomScrollBarTrackList = new sonavia.UserControls.CustomScrollBar();
            PanelTrackList = new Panel();
            PanelTrackTop = new Panel();
            label2 = new Label();
            label1 = new Label();
            ButtonCreate = new Button();
            ButtonCancel = new Button();
            TextBoxPlaylistName = new TextBox();
            label3 = new Label();
            PanelTrackContainer.SuspendLayout();
            PanelTrackListWrapper.SuspendLayout();
            PanelTrackTop.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(559, 32);
            PanelTop.TabIndex = 6;
            // 
            // ButtonClose
            // 
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ForeColor = SystemColors.Control;
            ButtonClose.Location = new Point(565, 0);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(32, 32);
            ButtonClose.TabIndex = 5;
            ButtonClose.Text = "X";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // PanelTrackContainer
            // 
            PanelTrackContainer.BackColor = Color.FromArgb(39, 36, 36);
            PanelTrackContainer.Controls.Add(PanelTrackListWrapper);
            PanelTrackContainer.Controls.Add(PanelTrackTop);
            PanelTrackContainer.Location = new Point(12, 38);
            PanelTrackContainer.Name = "PanelTrackContainer";
            PanelTrackContainer.Size = new Size(576, 259);
            PanelTrackContainer.TabIndex = 7;
            // 
            // PanelTrackListWrapper
            // 
            PanelTrackListWrapper.Controls.Add(CustomScrollBarTrackList);
            PanelTrackListWrapper.Controls.Add(PanelTrackList);
            PanelTrackListWrapper.Location = new Point(0, 49);
            PanelTrackListWrapper.Name = "PanelTrackListWrapper";
            PanelTrackListWrapper.Size = new Size(576, 210);
            PanelTrackListWrapper.TabIndex = 2;
            // 
            // CustomScrollBarTrackList
            // 
            CustomScrollBarTrackList.BackColor = Color.FromArgb(39, 36, 36);
            CustomScrollBarTrackList.LargeChange = 294;
            CustomScrollBarTrackList.Location = new Point(563, 0);
            CustomScrollBarTrackList.Maximum = 243;
            CustomScrollBarTrackList.Minimum = 0;
            CustomScrollBarTrackList.Name = "CustomScrollBarTrackList";
            CustomScrollBarTrackList.Size = new Size(10, 210);
            CustomScrollBarTrackList.TabIndex = 1;
            CustomScrollBarTrackList.Value = 0;
            CustomScrollBarTrackList.Scroll += PanelTrackList_Scroll;
            // 
            // PanelTrackList
            // 
            PanelTrackList.Location = new Point(0, 0);
            PanelTrackList.Name = "PanelTrackList";
            PanelTrackList.Size = new Size(560, 210);
            PanelTrackList.TabIndex = 2;
            // 
            // PanelTrackTop
            // 
            PanelTrackTop.Controls.Add(label2);
            PanelTrackTop.Controls.Add(label1);
            PanelTrackTop.Location = new Point(0, 0);
            PanelTrackTop.Name = "PanelTrackTop";
            PanelTrackTop.Size = new Size(576, 50);
            PanelTrackTop.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 14);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonCreate
            // 
            ButtonCreate.DialogResult = DialogResult.OK;
            ButtonCreate.FlatAppearance.BorderColor = Color.FromArgb(231, 138, 32);
            ButtonCreate.FlatAppearance.BorderSize = 2;
            ButtonCreate.FlatStyle = FlatStyle.Flat;
            ButtonCreate.Location = new Point(506, 331);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(82, 35);
            ButtonCreate.TabIndex = 7;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.FlatAppearance.BorderColor = Color.FromArgb(231, 138, 32);
            ButtonCancel.FlatAppearance.BorderSize = 2;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Location = new Point(418, 331);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(82, 35);
            ButtonCancel.TabIndex = 8;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonClose_Click;
            // 
            // TextBoxPlaylistName
            // 
            TextBoxPlaylistName.BackColor = Color.FromArgb(22, 22, 22);
            TextBoxPlaylistName.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPlaylistName.ForeColor = SystemColors.Control;
            TextBoxPlaylistName.Location = new Point(156, 298);
            TextBoxPlaylistName.Name = "TextBoxPlaylistName";
            TextBoxPlaylistName.Size = new Size(429, 26);
            TextBoxPlaylistName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 300);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 10;
            label3.Text = "Playlist name:";
            // 
            // AddPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(600, 378);
            Controls.Add(label3);
            Controls.Add(TextBoxPlaylistName);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonCreate);
            Controls.Add(PanelTrackContainer);
            Controls.Add(PanelTop);
            Controls.Add(ButtonClose);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AddPlaylistForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPlaylistForm";
            PanelTrackContainer.ResumeLayout(false);
            PanelTrackListWrapper.ResumeLayout(false);
            PanelTrackTop.ResumeLayout(false);
            PanelTrackTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelTop;
        private Button ButtonClose;
        private Panel PanelTrackContainer;
        private Button ButtonCreate;
        private Button ButtonCancel;
        private Panel PanelTrackTop;
        private Label label2;
        private Label label1;
        private Panel PanelTrackListWrapper;
        private UserControls.CustomScrollBar CustomScrollBarTrackList;
        private Panel PanelTrackList;
        private TextBox TextBoxPlaylistName;
        private Label label3;
    }
}