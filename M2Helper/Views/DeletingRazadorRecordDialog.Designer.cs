namespace Metin2Helper.Views
{
    partial class DeletingRazadorRecordDialog
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            noButton = new Guna.UI2.WinForms.Guna2Button();
            yesButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            deletingRazadorRecordDialogAnimation = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 46);
            panel1.Controls.Add(noButton);
            panel1.Controls.Add(yesButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 133);
            panel1.TabIndex = 0;
            // 
            // noButton
            // 
            noButton.CustomizableEdges = customizableEdges1;
            noButton.DisabledState.BorderColor = Color.DarkGray;
            noButton.DisabledState.CustomBorderColor = Color.DarkGray;
            noButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            noButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            noButton.FillColor = Color.Red;
            noButton.Font = new Font("Segoe UI", 9F);
            noButton.ForeColor = Color.White;
            noButton.Location = new Point(203, 80);
            noButton.Margin = new Padding(4, 3, 4, 3);
            noButton.Name = "noButton";
            noButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            noButton.Size = new Size(128, 40);
            noButton.TabIndex = 2;
            noButton.Text = "NO";
            noButton.Click += noButton_Click;
            // 
            // yesButton
            // 
            yesButton.CustomizableEdges = customizableEdges3;
            yesButton.DisabledState.BorderColor = Color.DarkGray;
            yesButton.DisabledState.CustomBorderColor = Color.DarkGray;
            yesButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            yesButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            yesButton.FillColor = Color.Green;
            yesButton.Font = new Font("Segoe UI", 9F);
            yesButton.ForeColor = Color.White;
            yesButton.Location = new Point(30, 80);
            yesButton.Margin = new Padding(4, 3, 4, 3);
            yesButton.Name = "yesButton";
            yesButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            yesButton.Size = new Size(128, 40);
            yesButton.TabIndex = 1;
            yesButton.Text = "YES";
            yesButton.Click += yesButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 53);
            label1.TabIndex = 0;
            label1.Text = "Are You Sure You Want To Delete This Record ?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deletingRazadorRecordDialogAnimation
            // 
            deletingRazadorRecordDialogAnimation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            deletingRazadorRecordDialogAnimation.TargetForm = this;
            // 
            // DeletingRazadorRecordDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(365, 135);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeletingRazadorRecordDialog";
            Padding = new Padding(1);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeletingRazadorRecordDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button yesButton;
        private Guna.UI2.WinForms.Guna2Button noButton;
        private Guna.UI2.WinForms.Guna2AnimateWindow deletingRazadorRecordDialogAnimation;
    }
}