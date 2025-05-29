namespace sonavia.Forms
{
    partial class WarningForm
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
            label1 = new Label();
            ButtonOpen = new Button();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(461, 32);
            PanelTop.TabIndex = 4;
            // 
            // ButtonClose
            // 
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ForeColor = SystemColors.Control;
            ButtonClose.Location = new Point(466, 0);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(32, 32);
            ButtonClose.TabIndex = 3;
            ButtonClose.Text = "X";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(449, 165);
            label1.TabIndex = 5;
            label1.Text = "Перед началом работы sonavia требуется указать директорию (папку), где будут распологаться ваши треки. Мы рекомендуем использовать базовую директорию \"Музыка\" в Windows.";
            // 
            // ButtonOpen
            // 
            ButtonOpen.FlatAppearance.BorderColor = Color.FromArgb(231, 138, 32);
            ButtonOpen.FlatAppearance.BorderSize = 2;
            ButtonOpen.FlatStyle = FlatStyle.Flat;
            ButtonOpen.Location = new Point(344, 203);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(144, 35);
            ButtonOpen.TabIndex = 6;
            ButtonOpen.Text = "Выбрать папку";
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // WarningForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(500, 250);
            Controls.Add(ButtonOpen);
            Controls.Add(label1);
            Controls.Add(PanelTop);
            Controls.Add(ButtonClose);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "WarningForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WarningForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Button ButtonClose;
        private Label label1;
        private Button ButtonOpen;
    }
}