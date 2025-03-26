using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonavia.Form
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static bool isPanelTopMouseClicked = false;
        private static Point formLocation;

        public MainForm()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            ButtonLibrary.FillColor = Color.FromArgb(231, 128, 32);
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
    }
}
