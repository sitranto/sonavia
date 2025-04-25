using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using sonavia.UserControls;
using sonavia;
using sonavia.Models;

namespace sonavia.Forms
{
    public partial class MainForm : Form
    {
        private static readonly FileManager fileManager = new();
        private static bool isPanelTopMouseClicked = false;
        private static Point formLocation;

        public MainForm()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            ActivateStartButtons();
            SetButtonsCollections();
            PaintTracksLibrary();
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            isPanelTopMouseClicked = true;
            formLocation = e.Location;
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isPanelTopMouseClicked = false;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPanelTopMouseClicked)
            {
                Location = new Point(Location.X - formLocation.X + e.X, Location.Y - formLocation.Y + e.Y);
                Update();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivateStartButtons()
        {
            actionButtonLibrary.FillColor = Utils.Color.orange;
            actionButtonQueue.FillColor = Utils.Color.orange;
            labelTitle.Text = "Библиотека:";
        }

        private void SetButtonsCollections()
        {
            foreach (ActionButton actionButton in splitContainerMain.Panel1.Controls.OfType<ActionButton>())
            {
                actionButton.SetPanelCollection([panelLibrary, panelAlbums, panelArtists]);
                // actionButton.SetPanelCollection(new Panel[] { panelLibrary, panelAlbums, panelArtists });
            }
            foreach (ActionButton actionButton in splitContainerыSupportive.Panel1.Controls.OfType<ActionButton>())
            {
                actionButton.SetPanelCollection([panelQueue, panelAbout]);
                // actionButton.SetPanelCollection(new Panel[] { panelQueue, panelAbout });
            }
        }

        private void PaintTracksLibrary()
        {
            var tracks = fileManager.GetAllTracks();
            var y = 67;

            foreach (var track in tracks)
            {
                var trackEntry = new TrackEntry(track);
                trackEntry.Location = new Point(12, y);
                y += trackEntry.Height;

                panelLibrary.Controls.Add(trackEntry);
            }
        }
    }
}
