using System.Windows.Forms;
using System.Drawing;

namespace sonavia.Forms
{
    partial class SelectLibraryDirectoryForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            actionButtonOpen = new UserControls.ActionButton();
            actionButtonClose = new UserControls.ActionButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 0;
            // 
            // actionButtonOpen
            // 
            actionButtonOpen.BackColor = Color.Transparent;
            actionButtonOpen.BorderRadius = 12;
            actionButtonOpen.CustomizableEdges = customizableEdges1;
            actionButtonOpen.DialogResult = DialogResult.OK;
            actionButtonOpen.DisabledState.BorderColor = Color.DarkGray;
            actionButtonOpen.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonOpen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonOpen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonOpen.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonOpen.Font = new Font("Segoe UI", 9F);
            actionButtonOpen.ForeColor = Color.White;
            actionButtonOpen.Location = new Point(433, 228);
            actionButtonOpen.Name = "actionButtonOpen";
            actionButtonOpen.ShadowDecoration.CustomizableEdges = customizableEdges2;
            actionButtonOpen.Size = new Size(130, 25);
            actionButtonOpen.TabIndex = 6;
            actionButtonOpen.Text = "Выбрать папку";
            actionButtonOpen.UseTransparentBackground = true;
            actionButtonOpen.Click += Open;
            // 
            // actionButtonClose
            // 
            actionButtonClose.BackColor = Color.Transparent;
            actionButtonClose.BorderRadius = 12;
            actionButtonClose.CustomizableEdges = customizableEdges3;
            actionButtonClose.DialogResult = DialogResult.Cancel;
            actionButtonClose.DisabledState.BorderColor = Color.DarkGray;
            actionButtonClose.DisabledState.CustomBorderColor = Color.DarkGray;
            actionButtonClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            actionButtonClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            actionButtonClose.FillColor = Color.FromArgb(112, 103, 103);
            actionButtonClose.Font = new Font("Segoe UI", 9F);
            actionButtonClose.ForeColor = Color.White;
            actionButtonClose.Location = new Point(297, 228);
            actionButtonClose.Name = "actionButtonClose";
            actionButtonClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            actionButtonClose.Size = new Size(130, 25);
            actionButtonClose.TabIndex = 7;
            actionButtonClose.Text = "Завершить работу";
            actionButtonClose.UseTransparentBackground = true;
            actionButtonClose.Click += Close;
            // 
            // SelectLibraryDirectoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(575, 265);
            Controls.Add(actionButtonClose);
            Controls.Add(actionButtonOpen);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectLibraryDirectoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SelectLibraryDrectoyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private UserControls.ActionButton actionButtonOpen;
        private UserControls.ActionButton actionButtonClose;
    }
}