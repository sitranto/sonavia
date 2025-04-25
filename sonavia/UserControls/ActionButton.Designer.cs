using System.Drawing;
using System.Windows.Forms;

namespace sonavia.UserControls
{
    partial class ActionButton
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SuspendLayout();
            // 
            // ActionButton
            // 
            BorderRadius = 12;
            DialogResult = DialogResult.None;
            DisabledState.BorderColor = Color.DarkGray;
            DisabledState.CustomBorderColor = Color.DarkGray;
            DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FillColor = Color.FromArgb(112, 103, 103);
            ShadowDecoration.CustomizableEdges = customizableEdges1;
            UseTransparentBackground = true;
            ResumeLayout(false);
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}
