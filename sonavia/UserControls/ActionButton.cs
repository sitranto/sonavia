using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonavia.UserControls
{
    public partial class ActionButton : Guna2Button
    {
        private Panel[]? panelCollection;

        public ActionButton()
        {
            InitializeComponent();
            Click += HandleActionButtonClick;
        }

        public void SetPanelCollection(Panel[] panelCollection)
        {
            this.panelCollection = panelCollection;
        }

        private void HandleActionButtonClick(object sender, EventArgs e)
        {
            ActionButton clickedButton = (ActionButton)sender;

            SetActionButtonColors(clickedButton);
            SetActivePanel(clickedButton);
        }

        private static void SetActionButtonColors(ActionButton clickedButton)
        {
            Control? parentContainer = clickedButton.Parent;

            foreach (ActionButton button in parentContainer!.Controls.OfType<ActionButton>())
            {
                if (button == clickedButton)
                {
                    button.FillColor = Utils.Color.orange;
                }
                else
                {
                    button.FillColor = Utils.Color.lightGray;
                }
            }
        }

        private void SetActivePanel(ActionButton clickedButton)
        {
            if (panelCollection?.Length == 3)
            {
                switch (clickedButton.Name)
                {
                    case "actionButtonLibrary": SetActivePanelOnContainer(panelCollection[0]); break;
                    case "actionButtonAlbums": SetActivePanelOnContainer(panelCollection[1]); break;
                    case "actionButtonArtists": SetActivePanelOnContainer(panelCollection[2]); break;
                }
            }
            if (panelCollection?.Length == 2)
            {
                switch (clickedButton.Name)
                {
                    case "actionButtonQueue": SetActivePanelOnContainer(panelCollection[0]); break;
                    case "actionButtonAbout": SetActivePanelOnContainer(panelCollection[1]); break;
                }
            }
        }

        private static void SetActivePanelOnContainer(Panel panelToActivate)
        {
            Control? parentContainer = panelToActivate.Parent;

            foreach (Panel panel in parentContainer!.Controls.OfType<Panel>())
            {
                if (panel == panelToActivate)
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }
    }
}
