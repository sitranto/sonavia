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
using sonavia.Utils;
using sonavia.UserControls;
using sonavia;

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

            // TODO тест метода, удалить в последствии
            label1.Text = fileManager.GetAllTracks()[0];
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
            }
            foreach (ActionButton actionButton in splitContainerыSupportive.Panel1.Controls.OfType<ActionButton>())
            {
                actionButton.SetPanelCollection([panelQueue, panelAbout]);
            }
        }
    }
}
