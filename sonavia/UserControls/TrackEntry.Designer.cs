using System.Windows.Forms;
using System.Drawing;

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
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(44, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.ForeColor = SystemColors.Control;
            labelArtist.Location = new Point(155, 14);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(81, 15);
            labelArtist.TabIndex = 1;
            labelArtist.Text = "Исполнитель";
            // 
            // labelAlbum
            // 
            labelAlbum.AutoSize = true;
            labelAlbum.ForeColor = SystemColors.Control;
            labelAlbum.Location = new Point(308, 14);
            labelAlbum.Name = "labelAlbum";
            labelAlbum.Size = new Size(51, 15);
            labelAlbum.TabIndex = 2;
            labelAlbum.Text = "Альбом";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.ForeColor = SystemColors.Control;
            labelDuration.Location = new Point(474, 14);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(84, 15);
            labelDuration.TabIndex = 3;
            labelDuration.Text = "Длительность";
            // 
            // TrackEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(labelDuration);
            Controls.Add(labelAlbum);
            Controls.Add(labelArtist);
            Controls.Add(labelName);
            Name = "TrackEntry";
            Size = new Size(599, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelArtist;
        private Label labelAlbum;
        private Label labelDuration;
    }
}
