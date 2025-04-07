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

namespace sonavia.Form
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static bool isPanelTopMouseClicked = false;
        private static Point formLocation;
        private static Color orange = Color.FromArgb(231, 128, 32);
        private static Color lightGray = Color.FromArgb(112, 103, 103);

        public MainForm()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            ButtonLibrary.FillColor = orange;
            ButtonQueue.FillColor = orange;
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

        private void PanelMain_ButtonClick(object sender, EventArgs e)
        {
            var clickedButton = (Guna2Button)sender;

            SetButtonColors(PanelMain.Controls, clickedButton);

            switch (clickedButton.Name)
            {
                case "ButtonLibrary":
                    PanelMainAlbums.Visible = false;
                    PanelMainArtists.Visible = false;
                    PanelMainLibrary.Visible = true;
                    break;
                case "ButtonAlbums": 
                    PanelMainLibrary.Visible = false;
                    PanelMainArtists.Visible = false;
                    PanelMainAlbums.Visible = true;
                    break;
                case "ButtonArtists":
                    PanelMainLibrary.Visible = false;
                    PanelMainAlbums.Visible = false;
                    PanelMainArtists.Visible = true;
                    break;
            }
        }

        private void PanelMulti_ButtonClick(object sender, EventArgs e)
        {
            var clickedButton = (Guna2Button)sender;

            SetButtonColors(PanelMulti.Controls, clickedButton);
        }

        private void SetButtonColors(Control.ControlCollection controls, Guna2Button clickedButton)
        {
            foreach (Control control in controls)
            {
                if (control is Guna2Button button)
                {
                    button.FillColor = lightGray;
                }
            }

            clickedButton.FillColor = orange;
        }
    }
}
