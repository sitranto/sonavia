using System.Windows.Forms;
using System.Drawing;

namespace sonavia.Forms
{
    partial class MainForm : System.Windows.Forms.Form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelTop = new Panel();
            ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            splitContainerыSupportive = new SplitContainer();
            actionButtonAbout = new UserControls.ActionButton();
            actionButtonQueue = new UserControls.ActionButton();
            panelAbout = new Panel();
            panelQueue = new Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            splitContainerMain = new SplitContainer();
            actionButtonArtists = new UserControls.ActionButton();
            actionButtonAlbums = new UserControls.ActionButton();
            actionButtonLibrary = new UserControls.ActionButton();
            labelTitle = new Label();
            panelArtists = new Panel();
            panelAlbums = new Panel();
            panelLibrary = new Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            player1 = new UserControls.Player();
            tableLayoutPanel1.SuspendLayout();
            PanelTop.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerыSupportive).BeginInit();
            splitContainerыSupportive.Panel1.SuspendLayout();
            splitContainerыSupportive.Panel2.SuspendLayout();
            splitContainerыSupportive.SuspendLayout();
            guna2PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            panelLibrary.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PanelTop, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(player1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(914, 513);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(ButtonClose);
            PanelTop.Dock = DockStyle.Fill;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Margin = new Padding(0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(914, 50);
            PanelTop.TabIndex = 5;
            PanelTop.MouseDown += PanelTop_MouseDown;
            PanelTop.MouseMove += PanelTop_MouseMove;
            PanelTop.MouseUp += PanelTop_MouseUp;
            // 
            // ButtonClose
            // 
            ButtonClose.CustomizableEdges = customizableEdges1;
            ButtonClose.DisabledState.BorderColor = Color.DarkGray;
            ButtonClose.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonClose.FillColor = Color.FromArgb(22, 22, 22);
            ButtonClose.Font = new Font("Segoe UI", 9F);
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Location = new Point(881, 8);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonClose.Size = new Size(30, 30);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "X";
            ButtonClose.Click += ButtonClose_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(guna2Panel2, 2, 0);
            tableLayoutPanel2.Controls.Add(guna2Panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(guna2PanelMain, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(908, 387);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BorderRadius = 12;
            guna2Panel2.Controls.Add(splitContainerыSupportive);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Fill;
            guna2Panel2.FillColor = Color.FromArgb(39, 36, 36);
            guna2Panel2.Location = new Point(683, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(222, 381);
            guna2Panel2.TabIndex = 2;
            // 
            // splitContainerыSupportive
            // 
            splitContainerыSupportive.BackColor = Color.Transparent;
            splitContainerыSupportive.Dock = DockStyle.Fill;
            splitContainerыSupportive.ForeColor = SystemColors.ControlText;
            splitContainerыSupportive.Location = new Point(0, 0);
            splitContainerыSupportive.Name = "splitContainerыSupportive";
            splitContainerыSupportive.Orientation = Orientation.Horizontal;
            // 
            // splitContainerыSupportive.Panel1
            // 
            splitContainerыSupportive.Panel1.Controls.Add(actionButtonAbout);
            splitContainerыSupportive.Panel1.Controls.Add(actionButtonQueue);
            // 
            // splitContainerыSupportive.Panel2
            // 
            splitContainerыSupportive.Panel2.Controls.Add(panelAbout);
            splitContainerыSupportive.Panel2.Controls.Add(panelQueue);
            splitContainerыSupportive.Size = new Size(222, 381);
            splitContainerыSupportive.SplitterDistance = 55;
            splitContainerыSupportive.TabIndex = 1;
            // 
            // actionButtonAbout
            // 
            actionButtonAbout.BackColor = Color.Transparent;
            actionButtonAbout.BorderRadius = 12;
            actionButtonAbout.CustomizableEdges = customizableEdges3;
            actionButtonAbout.DisabledState.BorderColor = Color.DarkGray;
            actionButtonAbout.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonAbout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonAbout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonAbout.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonAbout.Font = new Font("Segoe UI", 9F);
            actionButtonAbout.ForeColor = Color.White;
            actionButtonAbout.Location = new Point(111, 15);
            actionButtonAbout.Name = "actionButtonAbout";
            actionButtonAbout.ShadowDecoration.CustomizableEdges = customizableEdges4;
            actionButtonAbout.Size = new Size(90, 25);
            actionButtonAbout.TabIndex = 7;
            actionButtonAbout.Text = "Об аудио";
            actionButtonAbout.UseTransparentBackground = true;
            // 
            // actionButtonQueue
            // 
            actionButtonQueue.BackColor = Color.Transparent;
            actionButtonQueue.BorderRadius = 12;
            actionButtonQueue.CustomizableEdges = customizableEdges5;
            actionButtonQueue.DisabledState.BorderColor = Color.DarkGray;
            actionButtonQueue.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonQueue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonQueue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonQueue.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonQueue.Font = new Font("Segoe UI", 9F);
            actionButtonQueue.ForeColor = Color.White;
            actionButtonQueue.Location = new Point(15, 15);
            actionButtonQueue.Name = "actionButtonQueue";
            actionButtonQueue.ShadowDecoration.CustomizableEdges = customizableEdges6;
            actionButtonQueue.Size = new Size(90, 25);
            actionButtonQueue.TabIndex = 6;
            actionButtonQueue.Text = "Очередь";
            actionButtonQueue.UseTransparentBackground = true;
            // 
            // panelAbout
            // 
            panelAbout.Location = new Point(15, 116);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(200, 100);
            panelAbout.TabIndex = 1;
            panelAbout.Visible = false;
            // 
            // panelQueue
            // 
            panelQueue.Location = new Point(15, 19);
            panelQueue.Name = "panelQueue";
            panelQueue.Size = new Size(200, 100);
            panelQueue.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 12;
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(39, 36, 36);
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(39, 381);
            guna2Panel1.TabIndex = 1;
            // 
            // guna2PanelMain
            // 
            guna2PanelMain.BorderRadius = 12;
            guna2PanelMain.Controls.Add(splitContainerMain);
            guna2PanelMain.CustomizableEdges = customizableEdges17;
            guna2PanelMain.Dock = DockStyle.Fill;
            guna2PanelMain.FillColor = Color.FromArgb(39, 36, 36);
            guna2PanelMain.Location = new Point(48, 3);
            guna2PanelMain.Name = "guna2PanelMain";
            guna2PanelMain.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2PanelMain.Size = new Size(629, 381);
            guna2PanelMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            splitContainerMain.BackColor = Color.Transparent;
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.ForeColor = SystemColors.ControlText;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            splitContainerMain.Orientation = Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(actionButtonArtists);
            splitContainerMain.Panel1.Controls.Add(actionButtonAlbums);
            splitContainerMain.Panel1.Controls.Add(actionButtonLibrary);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(labelTitle);
            splitContainerMain.Panel2.Controls.Add(panelArtists);
            splitContainerMain.Panel2.Controls.Add(panelAlbums);
            splitContainerMain.Panel2.Controls.Add(panelLibrary);
            splitContainerMain.Size = new Size(629, 381);
            splitContainerMain.SplitterDistance = 55;
            splitContainerMain.TabIndex = 0;
            // 
            // actionButtonArtists
            // 
            actionButtonArtists.BackColor = Color.Transparent;
            actionButtonArtists.BorderRadius = 12;
            actionButtonArtists.CustomizableEdges = customizableEdges11;
            actionButtonArtists.DisabledState.BorderColor = Color.DarkGray;
            actionButtonArtists.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonArtists.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonArtists.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonArtists.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonArtists.Font = new Font("Segoe UI", 9F);
            actionButtonArtists.ForeColor = Color.White;
            actionButtonArtists.Location = new Point(237, 15);
            actionButtonArtists.Name = "actionButtonArtists";
            actionButtonArtists.ShadowDecoration.CustomizableEdges = customizableEdges12;
            actionButtonArtists.Size = new Size(105, 25);
            actionButtonArtists.TabIndex = 5;
            actionButtonArtists.Text = "Исполнители";
            actionButtonArtists.UseTransparentBackground = true;
            // 
            // actionButtonAlbums
            // 
            actionButtonAlbums.BackColor = Color.Transparent;
            actionButtonAlbums.BorderRadius = 12;
            actionButtonAlbums.CustomizableEdges = customizableEdges13;
            actionButtonAlbums.DisabledState.BorderColor = Color.DarkGray;
            actionButtonAlbums.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonAlbums.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonAlbums.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonAlbums.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonAlbums.Font = new Font("Segoe UI", 9F);
            actionButtonAlbums.ForeColor = Color.White;
            actionButtonAlbums.Location = new Point(126, 15);
            actionButtonAlbums.Name = "actionButtonAlbums";
            actionButtonAlbums.ShadowDecoration.CustomizableEdges = customizableEdges14;
            actionButtonAlbums.Size = new Size(105, 25);
            actionButtonAlbums.TabIndex = 4;
            actionButtonAlbums.Text = "Альбомы";
            actionButtonAlbums.UseTransparentBackground = true;
            // 
            // actionButtonLibrary
            // 
            actionButtonLibrary.BackColor = Color.Transparent;
            actionButtonLibrary.BorderRadius = 12;
            actionButtonLibrary.CustomizableEdges = customizableEdges15;
            actionButtonLibrary.DisabledState.BorderColor = Color.DarkGray;
            actionButtonLibrary.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonLibrary.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonLibrary.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonLibrary.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonLibrary.Font = new Font("Segoe UI", 9F);
            actionButtonLibrary.ForeColor = Color.White;
            actionButtonLibrary.Location = new Point(15, 15);
            actionButtonLibrary.Name = "actionButtonLibrary";
            actionButtonLibrary.ShadowDecoration.CustomizableEdges = customizableEdges16;
            actionButtonLibrary.Size = new Size(105, 25);
            actionButtonLibrary.TabIndex = 3;
            actionButtonLibrary.Text = "Библиотека";
            actionButtonLibrary.UseTransparentBackground = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.ForeColor = SystemColors.Control;
            labelTitle.Location = new Point(15, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(55, 16);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "label1";
            // 
            // panelArtists
            // 
            panelArtists.Location = new Point(426, 209);
            panelArtists.Name = "panelArtists";
            panelArtists.Size = new Size(200, 100);
            panelArtists.TabIndex = 2;
            panelArtists.Visible = false;
            // 
            // panelAlbums
            // 
            panelAlbums.Location = new Point(429, 91);
            panelAlbums.Name = "panelAlbums";
            panelAlbums.Size = new Size(200, 100);
            panelAlbums.TabIndex = 1;
            panelAlbums.Visible = false;
            // 
            // panelLibrary
            // 
            panelLibrary.AutoScroll = true;
            panelLibrary.Controls.Add(guna2Separator1);
            panelLibrary.Controls.Add(label4);
            panelLibrary.Controls.Add(label3);
            panelLibrary.Controls.Add(label2);
            panelLibrary.Controls.Add(label1);
            panelLibrary.Location = new Point(3, 19);
            panelLibrary.Name = "panelLibrary";
            panelLibrary.Size = new Size(623, 290);
            panelLibrary.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(12, 31);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(599, 10);
            guna2Separator1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(482, 12);
            label4.Name = "label4";
            label4.Size = new Size(103, 16);
            label4.TabIndex = 6;
            label4.Text = "Длительность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(348, 12);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 5;
            label3.Text = "Альбом";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(171, 12);
            label2.Name = "label2";
            label2.Size = new Size(95, 16);
            label2.TabIndex = 4;
            label2.Text = "Исполнитель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(38, 12);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // player1
            // 
            player1.BackColor = Color.Transparent;
            player1.Location = new Point(3, 446);
            player1.Name = "player1";
            player1.Size = new Size(908, 64);
            player1.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(914, 513);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sonavia";
            tableLayoutPanel1.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            splitContainerыSupportive.Panel1.ResumeLayout(false);
            splitContainerыSupportive.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerыSupportive).EndInit();
            splitContainerыSupportive.ResumeLayout(false);
            guna2PanelMain.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            panelLibrary.ResumeLayout(false);
            panelLibrary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel PanelTop;
        private Guna.UI2.WinForms.Guna2Button ButtonClose;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private SplitContainer splitContainerMain;
        private UserControls.ActionButton actionButtonArtists;
        private UserControls.ActionButton actionButtonAlbums;
        private UserControls.ActionButton actionButtonLibrary;
        private SplitContainer splitContainerыSupportive;
        private UserControls.ActionButton actionButtonAbout;
        private UserControls.ActionButton actionButtonQueue;
        private Label labelTitle;
        private Panel panelArtists;
        private Panel panelAlbums;
        private Panel panelLibrary;
        private Panel panelAbout;
        private Panel panelQueue;
        private UserControls.Player player1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label4;
        private Label label3;
    }
}